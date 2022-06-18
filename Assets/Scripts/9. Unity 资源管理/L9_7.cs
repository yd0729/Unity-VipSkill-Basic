using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L9_7 : MonoBehaviour
{
    public AudioSource _audioSource;
    public Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener(OnValueChanged);

        if (PlayerPrefs.HasKey("Volume"))
        {
            _slider.value = PlayerPrefs.GetFloat("Volume");
        }
        else
        {
            _slider.value = 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnValueChanged(float value)
    {
        _audioSource.volume = value;
        PlayerPrefs.SetFloat("Volume", value);
    }
}
