using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_7_MainPanel : MonoBehaviour
{
    public L4_7_MainPanel Instance;
    
    private Button _registerButton;
    private Button _loginButton;

    private void Awake()  // 单例模式
    {
        Instance = this;
    }

    void Start()
    {
        _registerButton = transform.Find("RegisterButton").GetComponent<Button>();
        _loginButton = transform.Find("LoginButton").GetComponent<Button>();
        
        _registerButton.onClick.AddListener(OnRegisterButtonClick);
        _loginButton.onClick.AddListener(OnLoginButtonClick);
    }

    private void OnRegisterButtonClick()
    {
        // 打开注册面板
        L4_7_RegisterPanel.Instance.Show();
        gameObject.SetActive(false);
    }
    
    private void OnLoginButtonClick()
    {
        // 打开登录面板
    }
}
