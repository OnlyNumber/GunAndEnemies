using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : Bullet
{

    [SerializeField]
    private Rigidbody _rb;

    public override void Shoot(Vector3 direction)
    {
        _rb.AddForce(direction * Speed,ForceMode.Acceleration);

    }

    
}
