using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class portalcena : MonoBehaviour

{  public void portal(string nome)
    {
        SceneManager.LoadScene(nome);
    }  
}
