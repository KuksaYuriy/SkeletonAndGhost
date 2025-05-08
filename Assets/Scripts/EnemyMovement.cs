using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speedMoving = 10f;
    public Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();   
    }
    void Update()
    {
        //Vector3 look = transform.right;
        //look = target.transform.position - transform.position;
        //transform.right = look;

        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speedMoving * Time.deltaTime);
        }
        
    }
}