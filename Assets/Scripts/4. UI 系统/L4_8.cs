using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_8 : MonoBehaviour
{
    private Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();

        _slider.onValueChanged.AddListener(OnSliderValueChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSliderValueChange(float value)
    {
        print(value);
    }
}
