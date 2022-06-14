using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_6 : MonoBehaviour
{
    private Toggle _toggle;
    
    // Start is called before the first frame update
    void Start()
    {
        _toggle = GetComponent<Toggle>();
        
        _toggle.onValueChanged.AddListener(OnValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("灯光：" + _toggle.isOn);
        }
    }
    
    private void OnValueChanged(bool isOn)
    {
        Debug.Log(isOn ? "Toggle is On" : "Toggle is Off");
    }
}
