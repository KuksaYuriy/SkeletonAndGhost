using UnityEditor.XR;
using UnityEngine;

public class AppleDrop : MonoBehaviour
{
    public float appleDroppingTime = 2f;
    public float timerDropping = 0f;
    public Rigidbody2D rb;
    public bool canDrop = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Invoke("FreezeApple", 3f);
    }
    void Update()
    {
        //        if (timerDropping < appleDroppingTime)
        //        {
        //            timerDropping += Time.deltaTime;
        //            transform.Translate(Vector3.down * 3f * Time.deltaTime);
        //        }

        if (canDrop)
        {
            transform.Translate(Vector3.down * 3f * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TreeGround"))
        {
            FreezeApple();
            canDrop = false;
        }
    }          
    void FreezeApple()
    {
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        
    }
}