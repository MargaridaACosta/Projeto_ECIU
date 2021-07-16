using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizz_correto : MonoBehaviour
{

public GameObject Resposta;
bool estadoA = false;



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void OnMouseUp(){

	print("botão em cima");

	estadoA = !estadoA;
	if (estadoA == true) {
	Resposta.GetComponent<Renderer>().material.SetColor("_Color", new Color(0f, 1f, 0f, 0.5f));
	} 
	// if (estadoA == true) {
	
//	RespostaA.GetComponent<Renderer>().material = errado;}


	
	}

}