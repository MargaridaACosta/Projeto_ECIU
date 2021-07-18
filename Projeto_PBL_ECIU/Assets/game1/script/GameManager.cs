using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOverText;
    public TextMeshProUGUI Congratulations;
    public TextMeshProUGUI Timer_Text;
    public TextMeshProUGUI Score_Text;

    private int Score;
    private int time;
    

    //public TextMeshProUGUI time Text;
    public bool isGameActive;
    public float timeValue = 90;
    public TextMeshProUGUI Timer;
    public Sprite RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        Score = 0;
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
        

    public void UpdateScore(int ScoreToAdd)
    {

        Score += ScoreToAdd;
        ScoreText.text = "Score:" + Score;

        if (Score == 8)
        {
            Congratulations.gameObject.SetActive(true);
            Timer_Text.gameObject.SetActive(false);
            Score_Text.gameObject.SetActive(false);

        }


    }

   // public void RestartGame()
   // {
   //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  //      Debug.Log("debug");
  //  }

    public void GameOver()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        RestartButton.gameObject.SetActive(true);
        GameOverText.gameObject.SetActive(true);
        Timer_Text.gameObject.SetActive(false);
        Score_Text.gameObject.SetActive(false);
        isGameActive = false;
    }
}
