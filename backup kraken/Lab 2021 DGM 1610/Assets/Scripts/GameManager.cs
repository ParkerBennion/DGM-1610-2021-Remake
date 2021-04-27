using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour

{
    public Sound[] sounds;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.clip;
            s.Source.volume = s.volume;
            s.Source.pitch = s.pitch;
            s.Source.loop = s.loop;
        }
    }
    //^^ this is assigning the variables in sound script to unity functions and is made serializable so you can see it in the inspector

    private void Start()
    {
        Play("GoMusic");
    }
    // this simply plays the the soundtrac with the assigned string in the inspector with "gomusic"

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.Source.Play();
    }
    // this refers to the sounds you assign in the unity editor as strings and will play them. the if statement is 
    // like a spell check where if you misspell the name of the sound it will return nothing in place of an error.
    // thank you brackies for the tutorial.
}
