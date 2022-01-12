using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    public CharacterController controlador;

    public float rapidez = 10;
    public float gravidade = -9.8f;
    public Transform checkChao;
    public float distanciaChao;
    public LayerMask maskChao;

    Vector3 velocidade;
    bool noChao;

 
    void Update()
    {
        noChao = Physics.CheckSphere(checkChao.position, distanciaChao, maskChao);

        if(noChao && velocidade.y < 0)
		{

            velocidade.y = -2f;

		}

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;

        controlador.Move(move * rapidez * Time.deltaTime);

        velocidade.y += gravidade * Time.deltaTime;

        controlador.Move(velocidade * Time.deltaTime);

        /*Programar as diferentes velocidades, para o estado de andar e o estado de corrida.
        if (Input.GetKey("left shift"))
        {
            rapidez = 25;
        }
        if (!Input.GetKey("left shift"))
        {
            rapidez = 10;
        }

       
        if (Input.GetKey("e"))
        {
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
        */

    }
}
