using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioScript : MonoBehaviour
{
    private MusicClass _audiosource;
    public AudioSource scene1;
    new private GameObject gameObject;

    // Use this for initialization
   
    
    void Start()
    {
        gameObject = GameObject.FindGameObjectWithTag("Musique");
        Destroy(gameObject);
        //scene1 = GameObject.Find("AudioSource").GetComponent<AudioSource>();
        Debug.Log("It Works");
    }

    public void Stop()
    {
        scene1.Stop();
    }
}