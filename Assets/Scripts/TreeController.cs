using System.Collections;
using System.Linq;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    public GameObject apple;
    public int delayAfterSpawnApple = 10;
    public int appleDropTime = 2;
    public bool canInteractTree = true;
    public Transform[] fruitSpawnPoints;
    public int spawnPoint1;
    public int spawnPoint2;
    public int spawnPoint3;
    public int spawnPoint4;

    public Transform spawnPoint1Obj;
    public Transform spawnPoint2Obj;
    public Transform spawnPoint3Obj;
    public Transform spawnPoint4Obj;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DropFruit();
        }
    }

    void DropFruit()
    {
        //Debug.Log("Start");
        if (!canInteractTree) return;
        //Debug.Log("Drop");

        //foreach (Transform spawnPoint in fruitSpawnPoints)
        //{
        //    GameObject fruit = Instantiate(apple, spawnPoint.position, Quaternion.identity);
        //    Rigidbody2D rb = fruit.GetComponent<Rigidbody2D>();
        //    //rb.isKinematic = false;
        //    //rb.AddForce(Vector2.down * appleDropTime, ForceMode2D.Impulse);
        //}

        spawnPoint1 = Random.Range(0, 19);
        spawnPoint2 = Random.Range(0, 19);
        spawnPoint3 = Random.Range(0, 19);
        spawnPoint4 = Random.Range(0, 19);

        spawnPoint1Obj = fruitSpawnPoints[spawnPoint1];
        spawnPoint2Obj = fruitSpawnPoints[spawnPoint2];
        spawnPoint3Obj = fruitSpawnPoints[spawnPoint3];
        spawnPoint4Obj = fruitSpawnPoints[spawnPoint4];

        Instantiate(apple, spawnPoint1Obj.position, Quaternion.identity);
        Instantiate(apple, spawnPoint2Obj.position, Quaternion.identity);
        Instantiate(apple, spawnPoint3Obj.position, Quaternion.identity);
        Instantiate(apple, spawnPoint4Obj.position, Quaternion.identity);
        StartCoroutine(TimerAppleDrop());
    }

    IEnumerator TimerAppleDrop()
    {
        canInteractTree = false;
        GetComponent<SpriteRenderer>().color = Color.gray;
        yield return new WaitForSeconds(delayAfterSpawnApple);
        canInteractTree = true;
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}