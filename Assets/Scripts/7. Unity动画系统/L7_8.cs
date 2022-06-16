using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7_8 : MonoBehaviour
{
    private CharacterController _characterController;
    private Animator _animator;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        var (h, v) = (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (h != 0 || v != 0)
        {
            _animator.SetBool("Run", true);
        }
        else
        {
            _animator.SetBool("Run", false);
        }

        Vector3 dir = new(h, 0, v);  // 输入方向
        dir = transform.TransformDirection(dir);  // 获得以 transform 为参考的方向（角色自己朝向的前方）
        _characterController.SimpleMove(dir * 4);  // 这个方法已经考虑了重力和帧率

        // 旋转（选择相对方向时）
        if (Input.GetKey(KeyCode.Q))
        {
            var newAngle = transform.eulerAngles;
            newAngle.y -= Time.deltaTime * 100;
            transform.eulerAngles = newAngle;
        }

        if (Input.GetKey(KeyCode.E))
        {
            var newAngle = transform.eulerAngles;
            newAngle.y += Time.deltaTime * 100;
            transform.eulerAngles = newAngle;
        }

        ///// 改变角色的朝向（选择绝对方向时）
        //Vector3 newAngles = transform.eulerAngles;
        //if (dir != Vector3.zero)
        //{
        //    if (dir.z > 0)
        //    {
        //        newAngles.y = Mathf.Atan(dir.x / dir.z) / Mathf.PI * 90;
        //    }
        //    else if (dir.z == 0)
        //    {
        //        newAngles.y = Sgn(dir.x) * 90;
        //    }
        //    else if (dir.z < 0)
        //    {
        //        newAngles.y = 180 + Mathf.Atan(dir.x / dir.z) / Mathf.PI * 90;
        //    }
        //}
        //transform.eulerAngles = newAngles;
        //////
    }

    int Sgn(float x)
    {
        if (x > 0)
        {
            return 1;
        }
        else if (x < 0)
        {
            return -1;
        }
        else // x == 0
        {
            return 0;
        }
    }
}
