using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_7Demo : MonoBehaviour
{
    private void Awake()
    {
        print("Awake：第 1 次被激活时执行 1 次");
    }

    private void OnEnable()
    {
        print("OnEnable：每次被激活时执行，在 Awake 之后");
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Start：执行 1 次，在 OnEnable 之后");
    }

    // Update is called once per frame
    void Update()
    {
        print("Update：每帧执行 1 次");
        print($"渲染上一帧的时间：{Time.deltaTime}");
    }

    private void LateUpdate()
    {
        print("LateUpdate：在 Update 之后执行");
    }

    private void FixedUpdate()
    {
        print("FixedUpdate：固定时间间隔");
    }

    private void OnDisable()
    {
        print("OnDisable：每次被禁用时执行");
    }

    private void OnDestroy()
    {
        print("OnDestory：当组件被销毁时执行，在 OnDisable 之后");
    }
}
