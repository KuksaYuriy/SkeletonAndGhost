using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject target;
    public GameObject attacker;
    public bool canAttack = true;
    public float cooldownTimeAttack = 2f;
    public int damage = 2;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ghost") && Input.GetMouseButtonDown(0) && canAttack)
        {
            target = collision.gameObject;
            Attack(collision);
        }
    }
    void Attack(Collision2D enemyCollision)
    {
        canAttack = false;
        EnemyHealth enemyHealth = target.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.GetEnemyDamage(damage);
            StartCoroutine(AttackDelay());
        }
    }
    private IEnumerator AttackDelay()
    {
        canAttack = false;
        yield return new WaitForSeconds(cooldownTimeAttack);
        canAttack = true;
    }
}
