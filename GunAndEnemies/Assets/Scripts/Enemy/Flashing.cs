using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing : MonoBehaviour
{
    [SerializeField]
    private Material CurrentMaterial;

    [SerializeField]
    private float delayBetweenFlashing;

    [SerializeField]
    private int flashingCount;

    [SerializeField]
    private Enemy _myEnemy;

    public Coroutine _currentCoroutine;

    private void Start()
    {
        _myEnemy.OnDamage += FlashingNow;
    }

    public void FlashingNow()
    {
        if(_currentCoroutine != null)
        {
            StopCoroutine(_currentCoroutine);

            CurrentMaterial.color = Color.white;
        }

        _currentCoroutine = StartCoroutine(Flash());
    }

    private IEnumerator Flash()
    {
        for (int i = 0; i < flashingCount; i++)
        {
        CurrentMaterial.color = Color.red;

        yield return new WaitForSeconds(delayBetweenFlashing);

        CurrentMaterial.color = Color.white;

        yield return new WaitForSeconds(delayBetweenFlashing);

        }


    }

}
