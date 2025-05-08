using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    //public static Coins Instance;
    public int coins;
    public Text coinsText;

    public void TakeCoins(int coinsTaken)
    {
        coins += coinsTaken;
        UpdateCoinsText();
    }

    public void UpdateCoinsText()
    {
        coinsText.text = coins.ToString();
    }
}