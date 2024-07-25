using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBullet : MonoBehaviour
{
    [SerializeField]
    private BulletForce _myBullet;

    [SerializeField]
    private int BounceAmount;

    private int CurrentBounce;

    [SerializeField]
    private float _radius;

    [SerializeField]
    private LayerMask _enemyLayer;

    private void Start()
    {
        _myBullet.OnTriggerBullet += Bounce;
    }

    private void Bounce(Collider collision)
    {
        List<Collider> hitsInfo = new List<Collider>();

        hitsInfo.AddRange( Physics.OverlapSphere(transform.position, _radius, _enemyLayer));
        
        hitsInfo.Remove(collision);


        if(collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.Damage();
        }

        if (hitsInfo.Count == 0 || CurrentBounce == BounceAmount) 
        {
            Destroy(gameObject);
        }

        CurrentBounce++;

        var direcion = hitsInfo[Random.Range(0, hitsInfo.Count)].transform.position - transform.position;

        _myBullet.Shoot(direcion);

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }

}
