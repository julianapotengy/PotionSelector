using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute : PropertyAttribute
{
    // potion selector attribute script
}

public class TestBehaviour : MonoBehaviour
{
    [PotionSelector]
    public Potion potion;

    public void Update()
    {
        Debug.Log(potion.name + " restores a total of " + potion.heal);
    }
}
