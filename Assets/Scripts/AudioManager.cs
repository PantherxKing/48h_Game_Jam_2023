using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float thisVolume;
    //the way this audiomanager works is to use both singleuse and randomized sounds (and music but it needs a loop)
    public static AudioManager instance;
    [SerializeField] public AudioSource source;
    [SerializeField] List<AudioClip> hitImpactSound = new List<AudioClip>();
    [Range(0.0f, 1.0f)]
    public float hitVolume;
    [SerializeField] List<AudioClip> dodgeSound = new List<AudioClip>();
    [Range(0.0f, 1.0f)]
    public float dodgeVolume;
    [SerializeField] AudioClip swordHitSound;
    [Range(0.0f, 1.0f)]
    public float swordVolume;
    [SerializeField] AudioClip horseSound;
    [Range(0.0f, 1.0f)]
    public float horseVolume;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            
        }
        source.volume = thisVolume;
    }

    public void hitSoundEffect()
    {
        AudioClip clip = hitImpactSound[UnityEngine.Random.Range(0, hitImpactSound.Count - 1)];
        source.volume = thisVolume * hitVolume;
        if (Time.timeScale != 0)
        {
            source.PlayOneShot(clip);
        }
    }

    public void swordSoundEffect()
    {
        source.clip = swordHitSound;
        source.volume = thisVolume * swordVolume;
        source.Play();
    }

    public void dodgeSoundEffect()
    {
        AudioClip clip = dodgeSound[UnityEngine.Random.Range(0, dodgeSound.Count - 1)];
        source.volume = thisVolume * dodgeVolume;
        if (Time.timeScale != 0)
        {
            source.PlayOneShot(clip);
        }
    }

    public void horseSoundEffect()
    {
        source.clip = horseSound;
        source.volume = thisVolume * horseVolume;
        source.Play();
    }

}

