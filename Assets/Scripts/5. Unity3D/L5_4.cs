using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print($"触发进入 {other.gameObject.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        print($"触发中 {other.gameObject.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        print($"触发退出 {other.gameObject.name}");
    }
}
