using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    protected float Speed;

    public System.Action<Collision> OnCollisionBullet;

    public System.Action<Collider> OnTriggerBullet;

    public virtual void Shoot(Vector3 direction) {}


    public void OnCollisionEnter(Collision collision)
    {
        OnCollisionBullet?.Invoke(collision);
    }

    private void OnTriggerEnter(Collider other)
    {
        OnTriggerBullet?.Invoke(other);
    }

}
