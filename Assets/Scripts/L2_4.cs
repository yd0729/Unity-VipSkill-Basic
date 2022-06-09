using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class L2_4 : MonoBehaviour
{
    // 碰撞事件是相互的，条件：
    // 1. 双方都有碰撞体
    // 2. 至少一方有刚体
    private void OnCollisionEnter2D(Collision2D col)
    {
        print($"碰撞进入，碰到了 {col.gameObject.name}");

        if (!col.gameObject.CompareTag("Bullet")) return;
        print("我被击中了");
        // GameObject.Destroy(col.gameObject);  // 销毁子弹

        // 这两种设定位置的方式有什么区别？
        col.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(-12, 2));
        // col.gameObject.transform.position = new Vector3(-12, 2);
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        print("碰撞结束");
    }


    private void OnCollisionStay2D(Collision2D col)
    {
        print("碰撞中");
    }
}
