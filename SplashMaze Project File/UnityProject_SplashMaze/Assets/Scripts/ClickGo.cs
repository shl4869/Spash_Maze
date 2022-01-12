using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClickGo : MonoBehaviour
{
    public void ExitMap()
    {
        Time.timeScale = 1;
        Invoke("ToHome", (float)0.072);
    }

    public void ToHome()
    {
        if (ClickAnimals.SelectedAnimal != -1) 
        { 
            SceneManager.LoadScene("2_Main"); 
        }
    }
}

