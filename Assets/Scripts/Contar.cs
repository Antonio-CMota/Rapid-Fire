using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contar : MonoBehaviour
{
    public static int pontos = 0;

    Text pontuacao;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pontuacao.text = pontos + " / 41";
    }
}
