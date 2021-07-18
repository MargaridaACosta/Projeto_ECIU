using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void SceneLoader(int ZoomableMap)
    {
        print("A mudar de scene");
        SceneManager.LoadScene(ZoomableMap);
    }
}
