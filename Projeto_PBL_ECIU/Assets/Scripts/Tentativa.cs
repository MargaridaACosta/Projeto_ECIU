using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tentativa : MonoBehaviour
{

    [SerializeField] private GameObject SairTutorial_1;
    [SerializeField] private GameObject SairTutorial_2;
    [SerializeField] private GameObject SairTutorial_3;



    public void OnMouseDown()
    {
      //  SairTutorial.SetActive(false);
    }


    public void SairTutorial()
    {
        SairTutorial_1.SetActive(false);
        SairTutorial_2.SetActive(false);
        SairTutorial_3.SetActive(false);

    }

    public void AbrirTutorial()
    {
        SairTutorial_1.SetActive(true);
        SairTutorial_2.SetActive(false);
        SairTutorial_3.SetActive(false);
    }

    public void Avancar_2()
    {
        SairTutorial_1.SetActive(false);
        SairTutorial_2.SetActive(true);
    }

    public void Avancar_3()
    {
        SairTutorial_2.SetActive(false);
        SairTutorial_3.SetActive(true);
    }

    public void Voltar_p_1()
    {
        SairTutorial_1.SetActive(true);
        SairTutorial_2.SetActive(false);
    }


    public void Voltar_p_2()
    {
        SairTutorial_2.SetActive(true);
        SairTutorial_3.SetActive(false);
    }

    
}
