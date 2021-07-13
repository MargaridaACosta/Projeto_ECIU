using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectibles : MonoBehaviour
{
    private GameManager GameManager;
    public int pointValue;
    public AudioSource AudioSource;

    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        GameManager.UpdateScore(pointValue);
        //Plays an Audio Source
        AudioSource.Play();
    }

    void Update()
    {
       //if (GameManager.timeValue <= 0)
        {
            //GameManager.GameOver();
        }
    }

}
