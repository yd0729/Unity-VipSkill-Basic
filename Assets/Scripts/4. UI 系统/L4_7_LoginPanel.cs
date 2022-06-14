using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_7_LoginPanel : MonoBehaviour
{
    public static L4_7_LoginPanel Instance;

    private InputField _userName;
    private InputField _password;

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

        L4_7_UserInfo userInfo = L4_7_GameManager.Instance.GetUserInfo(_userName.text);
        if (userInfo != null)
        {
            if (userInfo.Password != _password.text)
            {
                L4_7_FloatWindow.Instance.ShowInfo("密码错误");
                return;
            }
            else
            {
                L4_7_FloatWindow.Instance.ShowInfo("登录成功");
                return;
            }

        }
        else
        {
            L4_7_FloatWindow.Instance.ShowInfo("用户名不存在");
            return;
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
        _userName.text = "";
        _password.text = "";
    }
}
