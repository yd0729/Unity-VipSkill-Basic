using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L9_3 : MonoBehaviour
{
    private GameObject _prefabCubes;

    void Start()
    {
        Resources.Load<GameObject>("Prefabs/Cubes");
        GameObject cube = GameObject.Instantiate(_prefabCubes, new Vector3(0, 0, 0), Quaternion.identity, transform);
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out RaycastHit hit))
        {
            GameObject cube = GameObject.Instantiate(_prefabCubes, hit.point, Quaternion.identity, transform);
        }
    }
}
