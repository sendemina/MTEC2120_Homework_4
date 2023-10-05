using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject cubePrefab;

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject newCube = Instantiate(cubePrefab);
            newCube.transform.position = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        }

    }
}
