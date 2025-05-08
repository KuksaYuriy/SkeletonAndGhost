using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeChest : MonoBehaviour
{
    public bool isOpened = false;
    public Coins coinsController;

    void Start()
    {
        coinsController = GetComponent<Coins>();    
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chest"))
        {
            //Coins.Instance.TakeCoins(20);
            coinsController.TakeCoins(20);
            Destroy(collision.gameObject);  
        }
    }
}
