using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBullet : MonoBehaviour
{
    [SerializeField]
    private BulletForce _myBullet;

    private void Start()
    {
        _myBullet.OnCollisionBullet += Die;
    }

    public void Die(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        collision.gameObject.GetComponent<Enemy>().Damage();

        Destroy(gameObject);
    }

}
