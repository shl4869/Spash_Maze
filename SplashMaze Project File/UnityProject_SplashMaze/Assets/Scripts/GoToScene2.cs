using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene2 : MonoBehaviour
{
    public void ExitMap()
    {
        Time.timeScale = 1;
        Invoke("ToScene2", (float)0.072);
    }

    public void ToScene2()
    {

        SceneManager.LoadScene("1_Character");

    }

}