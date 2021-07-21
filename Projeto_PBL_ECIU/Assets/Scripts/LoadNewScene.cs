using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public void Hello()
    {
        Debug.Log("socoorrorroororor");
    }


    public void LoadScene_MyPassport()
    {
        SceneManager.LoadScene("MyPassport");
    }


    public void LoadScene_Achievements()
    {
        SceneManager.LoadScene("Achievements");
    }

    public void LoadScene_APP()
    {
        SceneManager.LoadScene("App Layout");
    }
}
