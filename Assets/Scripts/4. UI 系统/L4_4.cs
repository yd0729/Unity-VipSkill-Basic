using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class L4_4 : MonoBehaviour
{
    private Button _button;
    
    public void ButtonClick()
    {
        print("按钮点击");
    }
    
    private void ButtonClick2()
    {
        print("按钮点击 2");
    }

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ButtonClick2);
    }
}
