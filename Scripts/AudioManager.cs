using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Sound
{
    public AudioClip clip;
    public AudioSource source;

    public string name;

    public bool loop;
    public float volume;

    public void SetSound(AudioSource _source)
    {
        source = _source;
        source.clip = clip;
        source.loop = loop;
        source.volume = volume;
    }

    public void Play()
    {
        source.Play();
    }
}

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;

    private void Awake()
    {
        for(int i=0;i<sounds.Length;i++)
        {
            GameObject soundObj = new GameObject(""+i);
            sounds[i].SetSound(soundObj.AddComponent<AudioSource>());
            soundObj.transform.SetParent(transform);
        }
    }

    public void Play(string name)
    {
        for(int i=0;i<sounds.Length;i++)
        {
            if(name == sounds[i].name)
            {
                sounds[i].Play();
            }
        }
    }
}
