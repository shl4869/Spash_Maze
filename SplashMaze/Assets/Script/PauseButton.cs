﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public GameObject Option_Page;

    public void OptionDown()
    {
        if (Time.timeScale == 0)
            OptionConfirm();
        else
        {
            Time.timeScale = 0;
            Option_Page.SetActive(true);
        }

    }

    public void OptionConfirm()
    {
        Option_Page.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitMap()  //이건 게임 중단하고 홈으로 돌아가는 
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene("scene0");
    }
}