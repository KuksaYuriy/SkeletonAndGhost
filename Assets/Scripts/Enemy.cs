using UnityEngine;
public class Enemy : Interactable
{
    public override void Interact()
    {
        Debug.Log("Enemy Attacked");
    }
}