using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlManager : MonoBehaviour
{
    [SerializeField] public static LvlManager Instance;
    [SerializeField] public float currentExp = 0;
    [SerializeField] public float expToNextLvl = 100;
    [SerializeField] public int currentLvl = 1;
    [SerializeField] public Text lvlText;
    [SerializeField] public Text expText;
    [SerializeField] public Slider expSlider;
    public float expBefore;
    public float expAfter;


    void Start()
    {
        UpdateUI();
        expSlider.minValue = 0;
        expSlider.maxValue = expToNextLvl;
    }

    void Update()
    {
        //currentExp += 20 * Time.deltaTime;
        //AddExp(20 * Time.deltaTime);
    }
    public void AddExp(int exp)
    {
        Debug.Log($"Take {exp} exp");
        //currentExp += exp;
        expBefore = expSlider.value;
        expSlider.value += exp;
        expAfter = expBefore + exp;
        currentExp = expSlider.value;
        LvlUp();
        UpdateUI();
    }

    public void LvlUp()
    {
        if (expAfter >= expToNextLvl)
        {
            Debug.Log(expAfter);
            Debug.Log(expToNextLvl);

            if (expAfter - expToNextLvl > 0)
            {
                expAfter -= expToNextLvl;
            }
            else
            {
                expAfter = 0;
            }
            
            expToNextLvl *= 1.5f;
            expToNextLvl = Mathf.RoundToInt(expToNextLvl);
            currentLvl += 1;
            expSlider.value = expAfter;
            expSlider.maxValue = expToNextLvl;
            Debug.Log($"Current lvl: {currentLvl}");
            UpdateUI();
        }
    }
    
    public void UpdateUI()
    {
        lvlText.text = $"Level: {currentLvl}";
        expText.text = "Experience: " + Mathf.RoundToInt(expAfter) + "/" + expToNextLvl;
    }
}