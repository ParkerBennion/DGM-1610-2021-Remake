using UnityEngine.Audio;
using UnityEngine;
[System.Serializable]
    
public class Sound
{
    public string name;
        
        public AudioClip clip;
        
        [Range(0f,1f)]
        public float volume;
        [Range(.1f,3f)]
        public float pitch;

        public bool loop;
        //^^^ these are variables your adding to the inspector so they can be edited in game. but they are not assigned to anthing.
        
[HideInInspector]
        public AudioSource Source;
        //^^ this hides this from inspector view even though it is public.
}

//thank you brackies for the instruction