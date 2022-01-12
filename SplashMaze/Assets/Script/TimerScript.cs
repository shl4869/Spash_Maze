﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerScript : MonoBehaviour
{
    public Text[] text_time; // 시간을 표시할 text
    float time; // 시간

    // Start is called before the first frame update
    void Start()
    {
        time = 120;
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            CharacterEvent.isGameOver = true;
            Debug.Log("Game Over");
            //SceneManager.LoadScene("ending");
        }

        time -= Time.deltaTime;
        text_time[0].text = ((int)time / 60 % 60).ToString();
        text_time[1].text = ((int)time % 60).ToString();
        if (time <= 10)
        {
            text_time[0].text = "<color=red>" + text_time[0].text + "</color>";
            text_time[1].text = "<color=red>" + text_time[1].text + "</color>";
            text_time[2].text = "<color=red>" + text_time[2].text + "</color>";
        }

    }
}