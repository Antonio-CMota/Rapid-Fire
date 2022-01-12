using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float sensibilidade = 100f;

    public Transform corpo;

    float rotacaoX = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //Permite bloquear a posi��o do rato no centro do ecr�;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {

            //Calcula os valores para a rotacao dos eixos X e Y, mutliplicando pelo valor da sensibilidade do jogador, e por Tim.deltaTime, de modo a nao estar dependente da framerate do jogo.
            float ratoX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
            float ratoY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

            //Rota��o do rato
            rotacaoX -= ratoY;
            //Limite da rota��o do rato
            rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);

            //
            transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
            corpo.Rotate(Vector3.up * ratoX);

    }
}

