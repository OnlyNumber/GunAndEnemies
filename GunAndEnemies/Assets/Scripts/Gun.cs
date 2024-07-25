using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private BulletForce _currentBulletType;

    [SerializeField]
    private Transform _firePosition;

    public System.Action OnShoot;

    [SerializeField]
    private float _attackTime;

    private float _currentAttackTime;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _currentAttackTime <= 0)
        {
            Shoot();

            _currentAttackTime = _attackTime;
        }

        _currentAttackTime -= Time.deltaTime;
    }


    public void Shoot()
    {
        BulletForce bullet = Instantiate(_currentBulletType, _firePosition.position,Quaternion.identity);

        bullet.Shoot(_firePosition.forward);
        
        OnShoot?.Invoke();
    }

    public void ChangeBullet(BulletForce bulletType)
    {
        _currentBulletType = bulletType;
    }

}
