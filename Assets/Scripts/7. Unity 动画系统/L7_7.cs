using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7_7 : MonoBehaviour
{
    private CharacterController _characterController;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        print(_characterController.isGrounded);

        var (h, v) = (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //Vector3 dir = new Vector3(h, -9.8f, v);  // -9.8 模拟重力
        //_characterController.Move(dir * Time.deltaTime * 10);

        Vector3 dir = new Vector3(h, 0, v);
        _characterController.SimpleMove(dir * 10);  // 这个方法已经考虑了重力和帧率
    }
}
