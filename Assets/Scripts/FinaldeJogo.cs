using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FinaldeJogo : MonoBehaviour
{
    public static float pontuacao = 0f;
    public static float contabalas = 0f;
    public Text tempoperc;
    public Text balas;
    public GameObject statssair;
    public GameObject statsentrar;
    public GameObject camerassair;
    public GameObject cameraentrar;

    public Animator animacaofinal;

    private void Update()
    {
        pontuacao = Contar.pontos;
        contabalas = Arma.contadorbalas;

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("FPS").SendMessage("CorFinal"); //QUANDO O JOGADOR (FPS) COLIDIR COM O TRIGGER, ATIVA A FUNÇÃO "CorFinal"

        float precisao = pontuacao / contabalas;
        float percentagem = precisao * 100;

        /*Debug.Log("contador de pontos "+ pontuacao);
        Debug.Log("contador de balas "+ contabalas);*/

        tempoperc.text = percentagem.ToString() +"%";

        balas.text = contabalas.ToString();

        statssair.SetActive(false);
        statsentrar.SetActive(true);

        camerassair.SetActive(false);
        cameraentrar.SetActive(true);

        animacaofinal.SetBool("animacaofinal", true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        //Debug.Log(precisao);
    }


}
