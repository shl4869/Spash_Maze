using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToGame : MonoBehaviour
{
    public void ExitMap()
    {
        Time.timeScale = 1;
        Invoke("ToGame", (float)1.2);
    }

    public void ToGame()
    {

        SceneManager.LoadScene("3_GamePlay");

    }

}