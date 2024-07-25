using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleReactionOnHit : MonoBehaviour
{
    [SerializeField]
    private Enemy _myEnemy;

    [SerializeField]
    private ParticleSystem particleReaction;

    void Start()
    {
        _myEnemy.OnDamage += Reaction;
    }

    public void Reaction()
    {
        Instantiate(particleReaction, transform.position, Quaternion.identity);
    }

}
