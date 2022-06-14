using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class L2_5 : MonoBehaviour
{
    // 触发进入
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("触发进入");

        if (other.gameObject.name == "Player")
        {
            Destroy(other.gameObject);  // 销毁玩家
        }
    }
    
    // 触发中
    private void OnTriggerStay2D(Collider2D other)
    {
        print("触发中");
    }

    // 触发退出
    private void OnTriggerExit2D(Collider2D other)
    {
        print("触发退出");
    }
}
