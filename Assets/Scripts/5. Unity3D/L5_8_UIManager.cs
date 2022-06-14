using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L5_8_UIManager : MonoBehaviour
{
    public static L5_8_UIManager Instance;
    public Text ScoreNumber;
    public GameObject resultPanel;
    public Text result;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreNumber(int score)
    {
        ScoreNumber.text = score.ToString();
    }

    public void GameResult(bool isWin)
    {
        resultPanel.SetActive(true);
        if (isWin)
        {
            result.text = "WIN";
        }
        else
        {
            result.text = "LOSE";
        }
    }
}
