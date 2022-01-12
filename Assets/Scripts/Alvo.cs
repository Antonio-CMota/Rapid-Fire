using UnityEngine;

public class Alvo : MonoBehaviour
{
    public float vida = 50f;

    public morreraudio morteaudio;



    public void ReceberdDano (float quantidade)
    {
        //Se a vida do Inimigo for menor ou igual a 0, ele "morre" e desaparece
        vida -= quantidade;
        if(vida <= +0f)
        {
            Morre();
        }
    }

    void Morre()
    {
        Contar.pontos += 1;
        Debug.Log(Contar.pontos);
        Destroy(gameObject);
        morteaudio.Morrer();

    }
}
