using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public System.Action OnDamage;

    public void Damage()
    {
        OnDamage?.Invoke();
    }
}
