using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    private int score;
    private int time;

    //public TextMeshProUGUI time Text;
    public bool isGameActive;

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

    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;

        if (score == 30)
        {
            Debug.Log(score);
           
        }

    }
}
