using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour, IDamageable
{
    public void Damage()
    {
        Debug.Log("Owie");
    }
}
