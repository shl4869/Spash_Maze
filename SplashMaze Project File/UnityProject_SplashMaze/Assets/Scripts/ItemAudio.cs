using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAudio : MonoBehaviour
{
    private AudioSource SoundClip;

    [SerializeField] private AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        SoundClip = GetComponent<AudioSource>();        
    }

    void Update(){
        Debug.Log("UpdateRunning");
        Debug.Log("check LifeItem: "+ CharacterEvent.isLifeItem);
        if (CharacterEvent.isLifeItem == true)
        {
            Debug.Log(CharacterEvent.isLifeItem);
            PlaySE();
            
        }
        CharacterEvent.isLifeItem = false;
    }


    public void PlaySE()
    {
        SoundClip.clip = clip;
        SoundClip.Play();
    }
}
