using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class alterar : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("e"))
        {
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

            }
        }

    }
}
