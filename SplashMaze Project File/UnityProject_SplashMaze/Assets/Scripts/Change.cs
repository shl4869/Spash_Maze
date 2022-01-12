using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Change : MonoBehaviour
{
    public void ExitMap()
    {
        Time.timeScale = 1;
        Invoke("ToSelect", (float)0.072);
    }

    public void ToSelect()
    {
        SceneManager.LoadScene("1_Character");
    }
    
}

