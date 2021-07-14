using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectibles : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    public AudioSource AudioSource;
 

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnMouseDown()
    {
       
        {
            Destroy(this.gameObject);
            gameManager.UpdateScore(pointValue);
            //Plays an Audio Source
            AudioSource.Play();
        }
    }

    void Update()
    {
       //if (GameManager.timeValue <= 0)
        {
            //GameManager.GameOver();
        }
    }

}
