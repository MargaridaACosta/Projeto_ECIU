using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI ScoreText;
    private int score;
    private int time;
    

    //public TextMeshProUGUI time Text;
    public bool isGameActive;
    public float timeValue = 90;
    public TextMeshProUGUI Timer;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        score = 0;
        UpdateScore(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }
    void DisplayTime (float timetoDisplay)
    {
        if(timetoDisplay <0)
        {
            timetoDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timetoDisplay / 60);
        float seconds = Mathf.FloorToInt(timetoDisplay % 60);

        Timer.text =string.Format("Time: {0:00}:{1:00}",minutes,seconds);
    }
        

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        ScoreText.text = "Score: " + score;

    }
  public void GameOver()
    {
        
    }
}
