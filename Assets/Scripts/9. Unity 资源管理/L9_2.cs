using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L9_2 : MonoBehaviour
{
    public GameObject Prefab_Cubes;

    void Start()
    {
        GameObject cube = GameObject.Instantiate(Prefab_Cubes, new Vector3(0, 0, 0), Quaternion.identity, transform);
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out RaycastHit hit))
        {
            GameObject cube = GameObject.Instantiate(Prefab_Cubes, hit.point, Quaternion.identity, transform);
        }
    }
}
