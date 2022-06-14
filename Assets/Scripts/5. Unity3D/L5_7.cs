using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_7 : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    // 固定更新
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        // 获取输入
        var (h, v) = (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 offset = new(h, 0, v);  // x, y, z
        offset *= 0.02f * 3;
        _rigidbody.MovePosition(transform.position + offset);

    }
}
