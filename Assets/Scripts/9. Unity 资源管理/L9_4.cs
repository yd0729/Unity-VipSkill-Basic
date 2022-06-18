using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L9_4 : MonoBehaviour
{
    void Start()
    {
        // PlayerPrefs.SetString("PlayerName", "kkk");
        // PlayerPrefs.SetFloat("Value", 2.5f);
        // PlayerPrefs.SetInt("Age", 22);

        string playerName = PlayerPrefs.GetString("PlayerName");
        float value = PlayerPrefs.GetFloat("Value");
        int age = PlayerPrefs.GetInt("Age");

        print(playerName + " " + value + " " + age);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.SetString("PlayerName", "jjjj");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetFloat("Value", 3.5f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            print(PlayerPrefs.HasKey("PlayerName"));
        }
    }
}
