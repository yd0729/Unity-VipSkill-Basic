using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_9Demo : MonoBehaviour
{
    Coroutine cor;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Demo(10));
        StartCoroutine(Demo(10));
        StartCoroutine(Demo());
        cor = StartCoroutine(Demo());
        StartCoroutine(Stop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 协程函数
    public IEnumerator Demo(int num)
    {
        print($"最先执行，num = {num}");
        
        yield return null;  // 等待 1 帧 ？
        print("等待 1 帧");

        yield return new WaitForSeconds(3.0f); // 等待 3 秒
        print("等待 3 秒后执行");

        // 协程结束
    }

    public IEnumerator Demo()
    {
        yield return Demo(10);

        while (true)
        {
            transform.Rotate(new Vector3(0.5f, 0, 0));
            yield return new WaitForSeconds(0.01f);
        }

        // 这个协程自己不会结束
    }

    public IEnumerator Stop()
    {
        yield return new WaitForSeconds(1);
        StopCoroutine(Demo(10));  // 无效 ？

        yield return new WaitForSeconds(5);
        print("终止协程！");
        StopCoroutine(cor);  // 旋转变慢

        yield return new WaitForSeconds(5);
        print("终止全部协程！");
        StopAllCoroutines();
    }
}
