using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyResetter : MonoBehaviour
{
    public List<Rigidbody> rigidbodies;

    private List<Vector3> firstPositions = new List<Vector3>();

    private void Start()
    {
        foreach (var rigidbody in rigidbodies)
        {
            firstPositions.Add(rigidbody.transform.position);
        }
    }

    public void ResetAllEnemies()
    {
        for (int i = 0; i < rigidbodies.Count; i++)
        {
            rigidbodies[i].isKinematic = true;

            rigidbodies[i].transform.position = firstPositions[i];

            rigidbodies[i].isKinematic = false;

            rigidbodies[i].transform.rotation = Quaternion.Euler(0,180,0);
        }
    }
}
