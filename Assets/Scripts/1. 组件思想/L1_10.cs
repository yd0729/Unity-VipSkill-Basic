using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_10Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 右键查看 Mathf 中的所有函数
        print(Mathf.PI);
        print(Mathf.Round(2.5f));  // 4 舍 6 入 5 取偶
        print(Mathf.Round(3.5f));
        print(Random.Range(0, 5)); // [0, 5)
        print(Random.Range(0, 5.0f)); // [0.0, 5.0]
        print(Time.timeScale); // 默认是 1 ．默认情况下游戏时间会比现实时间小一点，为什么？

        //Time.timeScale = 0;  // 游戏暂停，游戏时间不变，现实时间增加，deltaTime = 0

        Time.timeScale = 0.5f;  // 游戏时间放慢
        
    }

    // Update is called once per frame
    void Update()
    {
        print($"游戏时间 Time.time = {Time.time}");  // 游戏运行到现在的时间，不算暂停
        print($"Time.deltaTime = {Time.deltaTime}");  // 从上一帧到当前帧的时间
        print($"现实时间 Time.realtimeSimceStartup = {Time.realtimeSinceStartup}");  // 自游戏开始后的总时间，即使暂停也会增加

        // 方向 * 速度 * 1 帧花费的时间
        transform.Translate(0, 1 * Time.deltaTime, 0);  // 每秒 1 个单位
    }
}
