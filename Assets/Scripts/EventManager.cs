using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    void OnEnable()
    {
        Player.onCubeHit += DestroyCube;
    }

    void OnDisable()
    {
        Player.onCubeHit -= DestroyCube;
    }

    void DestroyCube(GameObject cube)
    {
        Destroy(cube);
        Debug.Log("Cube destroyed");
    }
}
