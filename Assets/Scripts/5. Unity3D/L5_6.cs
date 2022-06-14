using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ray ray = new(Vector3.zero, Vector3.up);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit, 1000))
        {
            print($"射线碰到了 {raycastHit.collider.gameObject.name} ，在 {raycastHit.point}");
            Debug.DrawLine(ray.origin, raycastHit.point, Color.red);
        }
    }
}
