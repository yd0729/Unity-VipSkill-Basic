using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_3 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print($"碰撞进入 {collision.gameObject.name}");
    }

    private void OnCollisionStay(Collision collision)
    {
        print($"碰撞中 {collision.gameObject.name}");
    }

    private void OnCollisionExit(Collision collision)
    {
        print($"碰撞退出 {collision.gameObject.name}");
    }
}
