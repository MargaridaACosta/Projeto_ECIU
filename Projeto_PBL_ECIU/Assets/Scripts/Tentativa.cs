using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tentativa : MonoBehaviour
{

    [SerializeField] private GameObject SairTutorial;


    public void OnMouseDown()
    {
        SairTutorial.SetActive(false);
    }
}
