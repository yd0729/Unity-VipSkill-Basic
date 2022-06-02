using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_6Demo : MonoBehaviour
{
    private GameObject go;
    public Transform ts;
    public int Number { get; set; }  // 属性不能显示在编辑器中

    // Start is called before the first frame update
    void Start()
    {
        // 当前组件所在的游戏物体
        print(gameObject);
        print(gameObject.transform);  // 相当于直接访问 transform

        // Transform 继承自 Component , Component 里有 Transform 属性
        // 所以可以一直 .transform 但没什么意义，都是当前组件所在游戏物体的 transform
        print(transform.transform.transform.transform.transform.transform.transform.transform);

        print(gameObject.name);
        print(gameObject.tag);
        print(gameObject.activeInHierarchy);  // 是否激活

        go = GameObject.Find("C/D");  // 静态方法
        // 拿到 GameObject 就可以访问 Transform
        // position 世界坐标，编辑器中的坐标是相对于父物体的坐标
        print(go.name + " " +go.tag + " " + go.transform.position);
        // localPosition 是局部坐标，和编辑器中是一致的
        print(go.transform.localPosition);

        print(ts);
        print(ts.position);
        print(ts.gameObject);  // 拿到 Transform 也可以访问 GameObject

        print(gameObject.GetComponent<GameObject>()); // null
        print(gameObject.GetComponent<Transform>());  // transform
        print(gameObject.GetComponent<BoxCollider>().isTrigger);

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
