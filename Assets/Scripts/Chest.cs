using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactable
{
    public override void Interact()
    {
        Debug.Log("The chest was opened");
    }
}
