using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_7_RegisterPanel : MonoBehaviour
{
    public static L4_7_RegisterPanel Instance;
    
    private InputField _userName;
    private InputField _password;
    private InputField _confirmPassword;
    
    private Toggle _isMan;
    
    private Button _backButton;
    private Button _submitButton;

    private void Awake()
    {
        Instance = this;
        
        _userName = transform.Find("UserName").GetComponent<InputField>();
        _password = transform.Find("PassWord").GetComponent<InputField>();
        _confirmPassword = transform.Find("ConfirmPassword").GetComponent<InputField>();
        
        _isMan = transform.Find("GenderGroup/Toggle").GetComponent<Toggle>();
        
        _backButton = transform.Find("BackButton").GetComponent<Button>();
        _submitButton = transform.Find("SubmitButton").GetComponent<Button>();
        
        _backButton.onClick.AddListener(OnBackButtonClick);
        _submitButton.onClick.AddListener(OnSubmitButtonClick);
        
        gameObject.SetActive(false);
    }

    
    private void OnBackButtonClick()
    {
        // 返回主面板
        gameObject.SetActive(false);
    }

    private void OnSubmitButtonClick()
    {
        // 注册

    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
}
