using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_8Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 3 秒后执行
        Invoke(nameof(Demo), 3);

        // 2 秒后每隔一秒执行一次
        InvokeRepeating(nameof(Demo), 2, 1);

        // 5 秒后执行取消（上面 2 个都会取消）
        Invoke(nameof(CancelDemo), 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CancelDemo()
    {
        CancelInvoke(nameof(Demo)); 
    }

    void Demo()
    {
        print("Demo");
    }
}
