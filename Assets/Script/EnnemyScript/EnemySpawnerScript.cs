using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject EnemyPrefab;

    private float t = 0;

    void Update()
    {

        t += Time.deltaTime;
        if (t> 0.1f)
        {
            GameObject g = Instantiate(EnemyPrefab);
            g.transform.position =
                new Vector3(Random.Range(-25, 25), 50, Random.Range(-25, 25));
            t = 0;
        }

    }
}
