using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_5 : MonoBehaviour
{
    private  InputField _inputField;
    
    // Start is called before the first frame update
    void Start()
    {
        _inputField = GetComponent<InputField>();
        
        _inputField.text = "GGG";
        print(_inputField.text);
        
        _inputField.onValueChanged.AddListener(delegate {
            print("OnValueChanged:" +  _inputField.text);
        });
        
        _inputField.onEndEdit.AddListener(delegate {
            print("OnEndEdit:" + _inputField.text);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
