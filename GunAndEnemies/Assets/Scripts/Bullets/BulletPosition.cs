using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPosition : BulletForce
{

    private Vector3 _direction;

    private void Update()
    {
        transform.position = transform.position + _direction * Speed * Time.deltaTime;

        transform.forward = _direction;

    }

    public override void Shoot(Vector3 direction)
    {
        _direction = direction.normalized;

    }
}
