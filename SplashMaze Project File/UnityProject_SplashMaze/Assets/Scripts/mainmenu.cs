using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class mainmenu : MonoBehaviour
{
    public void ExitMap()
    {
        Time.timeScale = 1;
        Invoke("ToScene1", (float)0.072);
    }

    public void ToScene1()
    {

        SceneManager.LoadScene("0_Home");

    }

}