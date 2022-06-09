using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3_4_Player : MonoBehaviour
{
    public float horizontalForce;
    public float verticalForce;
    private Rigidbody2D _rigidbody2D;
    private bool _isOnGround;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 移动
        Move();
        Jump();
    }

    /// <summary>
    /// 移动
    /// </summary>
    void Move()
    {
        var h = Input.GetAxis("Horizontal");
        // var v = Input.GetAxis("Vertical");
        
        var direction = new Vector3(h, 0, 0);
        
        // 三种移动方式
        // transform.Translate(direction * (Time.deltaTime * speed));  // 只会移动，不会滚
        // _rigidbody2D.MovePosition(transform.position + direction * (Time.deltaTime * speed));
        _rigidbody2D.AddForce(direction * (Time.deltaTime * horizontalForce));  // 最真实
    }

    /// <summary>
    /// 跳跃
    /// </summary>
    void Jump()
    {
        if (!_isOnGround)
        {
            return;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * verticalForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnGround = false;
        }
    }
}
