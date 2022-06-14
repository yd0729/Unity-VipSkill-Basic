using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L4_11 : MonoBehaviour
{
    private ScrollRect _scrollRect;

    // Start is called before the first frame update
    void Start()
    {
        _scrollRect = GetComponent<ScrollRect>();
        _scrollRect.onValueChanged.AddListener(OnScrollRectValueChanged);
    }

    private void OnScrollRectValueChanged(Vector2 value)
    {
        print(value);
    }
}
