using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBullet : MonoBehaviour
{
    [SerializeField]
    private BulletForce _myBullet;

    [SerializeField]
    private float _radius;

    [SerializeField]
    private float _power;

    [SerializeField]
    private ParticleSystem _explosionParticles;

    private void Start()
    {
        _myBullet.OnCollisionBullet += Explosion;
    }

    public void Explosion(Collision collision)
    {
        Collider[] hitsInfo =  Physics.OverlapSphere(transform.position, _radius);

        foreach (var hit in hitsInfo)
        {
            if(hit.CompareTag("Enemy"))
            {
                hit.GetComponent<Enemy>().Damage();
            }
        }

        Instantiate(_explosionParticles,transform.position, Quaternion.identity);

        Destroy(gameObject);

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }

}
