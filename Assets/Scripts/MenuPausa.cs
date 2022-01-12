using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
	public static bool JogoEstaPausado = false;

	public GameObject MenuPausaUI;

	public GameObject Mira;

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (JogoEstaPausado) 
			{
				Continuar(); //CONDIÇAO PARA VERIFICAR SE ESTA PAUSADO, CASO ESTEJA AO CARREGAR ESCAPE ELE VOLTA A JOGO
			}
			else
				{

				Pausar(); //CONDIÇAO PARA VERIFICAR SE ESTA PAUSADO, CASO NAO ESTEJA AO CARREGAR ESCAPE ELE PAUSA O JOGO
			}
		}
    }

	public void Continuar() //FUNÇAO PARA CONTINUAR
	{
		MenuPausaUI.SetActive(false); //DESATIVAMOS O CANVAS DO MENU E VOLTAMOS AO JOGO
		Mira.SetActive(true);//ATIVAR A IMAGEM DA MIRA
		Time.timeScale = 1f;//O JOGO DEIXA DE ESTAR FREEZE
		JogoEstaPausado = false;//ASSIM O JOGO DEIXARA DE ESTAR PAUSADO
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

	}

	void Pausar() //FUNÇAO PARA PAUSAR O JOGO
	{
		MenuPausaUI.SetActive(true); //ATIVAR O CANVAS DO MENU 
		Mira.SetActive(false); //DEASTIVAR A IMAGEM DA MIRA
		Time.timeScale = 0f; //VARIAVEL PARA PARAR O JOGO (FREEZE TIME)
		JogoEstaPausado = true; //ASSIM O JOGO ESTARA PAUSADO
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;

	}

	public void CarregarMenu() //AO CARREGAR NO BOTAO MENU VAI ATIVAR ESTA FUNÇAO QUE NOS LEVARA PARA O MENU
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}

	public void Sair() //AO CARREGAR NO BOTAO SAIR VAI ATIVAR ESTA FUNÇAO QUE NOS LEVA A SAIR DO JOGO
	{
		Application.Quit();
	}
}
