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


    public void Load_Login()
    {
        SceneManager.LoadScene("Login");

    }

    public void Load_Registo()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Load_Landing()
    {
        SceneManager.LoadScene("LandingPage");
    }

    public void Load_Map()
    {
        SceneManager.LoadScene("Map");
    }
}
