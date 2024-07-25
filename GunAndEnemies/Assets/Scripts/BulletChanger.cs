using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletChanger : MonoBehaviour
{
    [SerializeField]
    private Gun _gunForChange;

    [SerializeField]
    private List<BulletForce> _bulletList;

    public void ChangeBullet(int bulletIndex)
    {
        _gunForChange.ChangeBullet(_bulletList[bulletIndex]);
    }

    public enum BulletType
    {
        Default,
        Explosive,
        Ricochet
    }
}
