using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Start : MonoBehaviour
{

    [SerializeField] private GameObject Start_Game;
    

    public void OnMouseDown()
    {

        if (Start_Game.activeSelf)
        {
            Start_Game.SetActive(false);
        }
    }

   


}
