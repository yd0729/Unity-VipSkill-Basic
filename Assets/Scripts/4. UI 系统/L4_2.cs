using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI 命名空间

public class L4_2 : MonoBehaviour
{
    private Image _image;
    
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
        _image.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
