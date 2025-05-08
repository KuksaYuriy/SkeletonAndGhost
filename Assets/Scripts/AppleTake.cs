using UnityEngine;
using UnityEngine.UI;

public class AppleTake : MonoBehaviour
{
    public Coins coinsController;

    void Start()
    {
        coinsController = GetComponent<Coins>();    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        { 
            Destroy(collision.gameObject);
            //Coins.Instance.TakeCoins(1);
            coinsController.TakeCoins(1);
        }
    }
}
