using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_7_FloatWindow : MonoBehaviour
{
    
    public static L4_7_FloatWindow Instance;
    private Text _infoText;
    private Button _okButton;
    
    private void Awake() // 单例模式
    {
        Instance = this;
        
        _infoText = transform.Find("InfoText").GetComponent<Text>();
        _okButton = transform.Find("OKButton").GetComponent<Button>();

        _okButton.onClick.AddListener(OnOkButtonClick);
        
        gameObject.SetActive(false);
    }

    private void ShowInfo(string info)
    {
        gameObject.SetActive(true);
        _infoText.text = info;
    }
    
    private void OnOkButtonClick()
    {
        gameObject.SetActive(false);
    }
}
