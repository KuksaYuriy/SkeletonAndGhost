using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHp = 10;
    public int currentHp = 10;

    void Update()
    {
        //AlwaysAttackPlayer();
    }
    void AlwaysAttackPlayer()
    {
        GetPlayerDamage(1);
        StartCoroutine(Cooldown());
    }
    void GetPlayerDamage(int damage)
    {
        currentHp -= damage;
        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log($"Player Attacked, {currentHp} HP");
    }

    private IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(5);
    }
}