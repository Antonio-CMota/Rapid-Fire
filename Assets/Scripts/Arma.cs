
using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour
{
    public float dano = 10f; //Valor de dano da arma
    public Camera camerafps; //Camera do jogador
    public GameObject impacto; //Objeto de impacto (marca da bala)

    public int municaoMax = 8; //Munição máxima
    private int municaoAtual; //Munição atual
    public float recarregar = 1f; //Tempo de reload
    private bool estaRecarregar = false; //Verificação do estado de reload

    public static bool estaDisparar = false; //Verificação do estado de reload

    public static int contadorbalas = 0; //Tiros disparados

    public Animator animacao; //Animação de reload

    public AudioSource audiorecarregar;

    public tirosaudio tirosaudio;


    //Começa com a munição no máximo
    private void Start()
    {
        municaoAtual = municaoMax; //Começa o jogo com a munição máxima
        contadorbalas = 0;
    }

    void Update()
    {
        if (estaRecarregar)
            return;

        //Toda a vez que a munição for inferior ou igual a 0, o jogador terá que recarregar
        if(municaoAtual <= 0)
        {
            StartCoroutine(Recarregar());
            return;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            tirosaudio.Disparar();

        }
    }

    IEnumerator Recarregar()
    {
        estaRecarregar = true; //Altera o estado de reload para ativo
        //Debug.Log("Recarregar");

        audiorecarregar.Play();

        animacao.SetBool("recarregar", true); //Altera o estado da animação de reload para ativo

        yield return new WaitForSeconds(recarregar - .25f); //Altera o tempo da animação para -.25 valores
        animacao.SetBool("recarregar", false); //Altera o estado da animação de reload para inativo
        yield return new WaitForSeconds(.25f); //Altera o tempo da animação para .25 valores

        municaoAtual = municaoMax; //Ao recarregar a munição volta para o seu número máximo
        estaRecarregar = false; //Altera o estado de reload para inativo
    }

    public void Shoot()
    {

        municaoAtual--; //Cada vez que dispara retira uma bala à munição

        contadorbalas++; //Cada vez que dispara acrescenta uma bala ao contador

        //Debug.Log(contadorbalas);

        RaycastHit hit;
        //Codigo para retirar informação da posicão do jogador e para onde o mesmo está a olhar
        if(Physics.Raycast(camerafps.transform.position, camerafps.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            //Se o objeto em que o jogador atirou tiver o scipt "Alvo", o mesmo levará dano
            Alvo alvo = hit.transform.GetComponent<Alvo>();

            if(alvo != null)
            {
                alvo.ReceberdDano(dano);
            }

            //Na superficie atingida irá aparecer uma bolinha 
            GameObject impactoGO = Instantiate(impacto, hit.point, Quaternion.LookRotation(hit.normal));

            Destroy(impactoGO, 1f);


        }
    }
}