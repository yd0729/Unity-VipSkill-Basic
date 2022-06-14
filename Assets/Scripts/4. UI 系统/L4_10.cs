using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_10 : MonoBehaviour
{
    private Dropdown _dropdown;

    // Start is called before the first frame update
    void Start()
    {
        _dropdown = GetComponent<Dropdown>();

        _dropdown.onValueChanged.AddListener(OnDropdownValueChange);
    }

    private void OnDropdownValueChange(int value)
    {
        print(value);
    }
}
