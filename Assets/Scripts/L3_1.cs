using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class L3_1 : MonoBehaviour
{
    public KeyCode attackKey;
    private float _attackValue;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 按下
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("按了 A");
        }
        
        if (Input.GetKeyDown(attackKey))
        {
            print("开始蓄力");
            _attackValue = 0;
        }

        // 按下中
        if (Input.GetKey(KeyCode.A))
        {
            print("持续按 A");
        }
        
        if (Input.GetKey(attackKey))
        {
            print("蓄力中");
            _attackValue += Time.deltaTime;
        }

        // 弹起
        if (Input.GetKeyUp(KeyCode.A))
        {
            print("弹起 A");
        }
        
        if (Input.GetKeyUp(attackKey))
        {
            print($"发动攻击，攻击力 = {_attackValue}");
        }
    }
}
