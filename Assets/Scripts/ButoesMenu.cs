using UnityEngine;
using UnityEngine.SceneManagement;

public class ButoesMenu : MonoBehaviour
{
    public int nextScene;

    public void changeScreen()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void Sair()
    {
        Application.Quit();
    }

}