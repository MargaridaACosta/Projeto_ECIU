using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }


    public void ResetScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


}
