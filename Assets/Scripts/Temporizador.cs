using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    
    public Text tempoTexto;
    public Text tempoTexto2;

    private float IniciarTempo;


    private bool terminar = false; // VARIAVEL PARA VERIFICAR SE O PERCURSO FOR TERMINADO

    void Start()
    {
        IniciarTempo = Time.time; // DA O TEMPO DESDE QUE APLICAÇÃO INICIA
        Contar.pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (terminar)
        {
            return; //CASO O PERCURSO TIVER TERMINADO E O TRIGGER FOR ATIVADO, DÁ RETURN DOS VALORES ATUAIS DO TIMER
        }

        float tempo = Time.time - IniciarTempo; //DA O TEMPO DESDE QUE O TIMER COMEÇOU
        string minutes = ((int)tempo / 60).ToString(); // COM ESTA CONDIÇÃO CONSEGUIMOS A QUANTIDADE DE MINUTOS
		string seconds = (tempo % 60).ToString("f2"); //F2 DOIS VAI DEFINIR QUE QUERO APENAS DOIS FLOATS, E AQUI CONSEGUIMOS OS NUMEROS DE SEGUNDOS

        tempoTexto.text = minutes + ":" + seconds; //TEXTO DO TEXT

        tempoTexto2.text = tempoTexto.text;
    }

    public void CorFinal()
    {
        terminar = true; // PERCURSO TERMINADO

        tempoTexto.color = Color.green; // ALTERA A COR DO TIMER
        tempoTexto2.color = Color.green; // ALTERA A COR DO TIMER
    }
}
