using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class L3_3 : MonoBehaviour
{
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        transform.Translate(h, v, 0);

        var wheel = Input.GetAxis("Mouse ScrollWheel");
        print(wheel);
    }
}
