using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] Sprite[] swapImage = new Sprite[2];
    public GameObject Button;
    public GameObject Option_Page;

    public AudioSource SoundClip;

    [SerializeField] public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        SoundClip = GetComponent<AudioSource>();
        PlayBg();    
    }

    public void OptionDown()
    {
        if (Time.timeScale == 0)
            OptionConfirm();
        else
        {
            PauseBg();
            Time.timeScale = 0;
            Option_Page.SetActive(true);
            Button.GetComponent<Image>().sprite = swapImage [1];
            Button.GetComponent<Image>().SetNativeSize();
        }
        
    }

    public void OptionConfirm()
    {
        PlayBg();
        Option_Page.SetActive(false);
        Time.timeScale = 1;
        Button.GetComponent<Image>().sprite = swapImage [0];
        Button.GetComponent<Image>().SetNativeSize();
    }

    public void ExitMap()  //이건 게임 중단하고 홈으로 돌아가는 
    {
        Time.timeScale = 1;
        Invoke("ToHome",(float)0.072);
    }

    public void PauseBg()
    {
        SoundClip.clip = clip;
        SoundClip.Pause();   
    }
    public void PlayBg()
    {
        SoundClip.clip = clip;
        SoundClip.Play();   
        SoundClip.loop = true;
    }

    public void ToHome()
    {
        Debug.Log("toHome");
        SceneManager.LoadScene("2_Main");
    }
}
