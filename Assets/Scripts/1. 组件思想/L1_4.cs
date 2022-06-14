using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_5Transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print($"坐标：{transform.position}");
        print($"旋转：{transform.rotation}");  // rotation 是四元数
        print($"缩放：{transform.localScale}");
        print($"子物体个数：{transform.childCount}");
        print($"父物体：{transform.parent}");
        print($"根物体：{transform.root}");
        print($"欧拉角：{transform.eulerAngles}");  // 这个欧拉角才对应 Transform 面板中的 Roataion
        print($"查找 C ：{transform.Find("C")}");  
        //transform.position = new Vector3(10, 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.01f, 0, 0));  // 传入的是一个方向
        transform.Rotate(new Vector3(1, 1, 0));  // 传入的是一个角度（没用，因为下面有 lookat）
        transform.LookAt(transform.parent);  // 看向
    }
}
