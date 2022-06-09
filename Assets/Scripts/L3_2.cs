using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class L3_2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("左键按下");
            print(Input.mousePosition);
        }
        
        if (Input.GetMouseButton(0))
        {
            print("左键按下中");
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            print("左键弹起");
        }
    }
}
