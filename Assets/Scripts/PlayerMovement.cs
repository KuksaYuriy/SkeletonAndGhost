using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speedMoving = 10f;
    public float maxStamina = 100f;
    private float currentStamina = 100f;
    public float speedUseStamina = 5f;
    public float speedRegenarationStamina = 2.5f;
    public bool canSprinting;
    public Slider staminaSlider;

    void Start()
    {
        staminaSlider.maxValue = maxStamina;
        staminaSlider.value = currentStamina;
    }
    void Update()
    {
        if ((currentStamina > 0) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
            canSprinting = true;
        }
        else
        {
            canSprinting = false;
        }
        ControlStamina();
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, vertical, 0) * speedMoving * Time.deltaTime;
    }

    void ControlStamina()
    {
        if (canSprinting)
        {
            if (currentStamina > 0)
            {
                speedMoving = 15f;
                currentStamina -= speedUseStamina * Time.deltaTime;
            }
            else
            {
                canSprinting = false;
            }
        }
        else 
        {
            speedMoving = 10f;
            if (currentStamina < maxStamina)
            {
                currentStamina += speedRegenarationStamina * Time.deltaTime;
            }
        }
        staminaSlider.value = currentStamina;
    }
}