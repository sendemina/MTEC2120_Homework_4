using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public delegate void OnCubeHit(GameObject cube);
    public static event OnCubeHit onCubeHit;

    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f) && Input.GetMouseButton(0))
        {
            onCubeHit?.Invoke(raycastHit.rigidbody.gameObject);
        }
    }
}
