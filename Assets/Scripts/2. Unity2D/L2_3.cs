using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_3 : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.mass = 3;
        _rigidbody2D.gravityScale = 0.5f;
        
        _rigidbody2D.MovePosition(new Vector2(0, 0));  // 坐标
    }

    // Update is called once per frame
    void Update()
    {
        // _rigidbody2D.velocity = new Vector2(0, 1);  // 改变力
        _rigidbody2D.AddForce(Vector2.up * (10f * Time.deltaTime));  // 施加力
    }
}
