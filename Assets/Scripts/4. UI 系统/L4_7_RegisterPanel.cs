using System;
using System.Collections;
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
    }

    private void Start()
    {
        _userName = transform.Find("UserName/InputField").GetComponent<InputField>();
        _password = transform.Find("Password/InputField").GetComponent<InputField>();
        _confirmPassword = transform.Find("ConfirmPassword/InputField").GetComponent<InputField>();

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
        L4_7_MainPanel.Instance.Show();
        gameObject.SetActive(false);
    }

    private void OnSubmitButtonClick()
    {
        // 注册
        if (string.IsNullOrEmpty(_userName.text))
        {
            L4_7_FloatWindow.Instance.ShowInfo("用户名不能为空");
            return;
        }
        if (string.IsNullOrEmpty(_password.text))
        {
            L4_7_FloatWindow.Instance.ShowInfo("密码不能为空");
            return;
        }
        if (string.IsNullOrEmpty(_confirmPassword.text))
        {
            L4_7_FloatWindow.Instance.ShowInfo("确认密码不能为空");
            return;
        }
        if (_password.text != _confirmPassword.text)
        {
            L4_7_FloatWindow.Instance.ShowInfo("两次密码不一致");
            return;
        }
        if (L4_7_GameManager.Instance.GetUserInfo(_userName.text) != null)
        {
            L4_7_FloatWindow.Instance.ShowInfo("用户名已存在");
            return;
        }
        // 保存账户信息
        L4_7_UserInfo userInfo = new(_userName.text, _password.text, _isMan.isOn);
        L4_7_GameManager.Instance.SaveUserInfo(userInfo);

        L4_7_FloatWindow.Instance.ShowInfo("注册成功，请登录！");
    }

    public void Show()
    {
        gameObject.SetActive(true);
        _userName.text = "";
        _password.text = "";
        _confirmPassword.text = "";
        _isMan.isOn = true;
    }
}
