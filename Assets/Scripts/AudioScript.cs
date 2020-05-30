using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private MusicClass _audiosource;
    public AudioSource scene1;
    // Use this for initialization
    void Start()
    {
        scene1 = GameObject.Find("AudioSource").GetComponent<AudioSource>();
        Debug.Log("TEST");
    }

    public void Stop()
    {
        scene1.Stop();
    }
}