using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth = 10;
    public LvlManager lvlManager;

    //public Canvas canvasHpPrefab;
    //public Slider sliderHp;
    //public RectTransform rectGhostHpSlider;

    //void Start()
    //{
    //    CreateHpGhostUI();
    //}

    //void Update()
    //{
    //    rectGhostHpSlider.transform.position = transform.position + new Vector3(0, 2, 0);
    //    Debug.Log(transform.position + " " + rectGhostHpSlider.transform.position);
    //}

    public void Start()
    {
        lvlManager = GetComponent<LvlManager>();
    }
    public void GetEnemyDamage(int damage)
    {
        Debug.Log("Enemy Attacked, HP: " + currentHealth);
        currentHealth -= damage;
        
        if (currentHealth <= 0)
        {
            //LvlManager.Instance.AddExp(100);
            lvlManager.AddExp(65);
            Destroy(gameObject);
        }
    }

    //void CreateHpGhostUI()
    //{
    //    GameObject ghostUiPrefab = Resources.Load<GameObject>("HealthGhostUICanvas (1) 1 1");
    //    GameObject ghostHpSliderClone = Instantiate(ghostUiPrefab, transform);
    //    rectGhostHpSlider = ghostHpSliderClone.GetComponent<RectTransform>();
    //    rectGhostHpSlider.transform.position = transform.position + new Vector3(0, 2, 0);
    //    Debug.Log("End CreateGhostUI");
    //}
}