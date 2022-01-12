using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTutorial : MonoBehaviour
{
    public void ExitMap()
    {
        Time.timeScale = 1;
        Invoke("ToTutorial", (float)0.8);
    }

    public void ToTutorial()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}
