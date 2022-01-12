using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    private AudioSource SoundClip;

    [SerializeField] private AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        SoundClip = GetComponent<AudioSource>();        
    }

    public void PlaySE()
    {
        SoundClip.clip = clip;
        SoundClip.Play();
    }
}
