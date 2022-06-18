using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L9_5 : MonoBehaviour
{
    void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);  // 不要销毁我
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("4. 数据存档 - PlayerPrefsr");
        }
    }
}
