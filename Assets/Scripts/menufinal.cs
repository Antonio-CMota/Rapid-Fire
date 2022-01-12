using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menufinal : MonoBehaviour
{

    public void CarregarMenu() //AO CARREGAR NO BOTAO MENU VAI ATIVAR ESTA FUNÇAO QUE NOS LEVARA PARA O MENU
    {
        SceneManager.LoadScene(0);
    }

    public void Reiniciar() //AO CARREGAR NO BOTAO REINICIAR VAI ATIVAR ESTA FUNÇAO QUE NOS LEVA A REINICIAR O JOGO
    {
        SceneManager.LoadScene(1);
    }


}
