using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHome : MonoBehaviour
{
    public void ExitMap()
    {
        Time.timeScale = 1;
        Invoke("ToHome", (float)0.072);
    }

    public void ToHome()
    {
        SceneManager.LoadScene("2_Main");
    }
}

