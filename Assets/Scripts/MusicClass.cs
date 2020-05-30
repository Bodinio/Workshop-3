﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    private AudioSource _musicLevel;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();

       /* if (SceneManager.GetActiveScene().name == "1-1" || SceneManager.GetActiveScene().name == "1-2" || SceneManager.GetActiveScene().name == "1-3" || SceneManager.GetActiveScene().name == "1-4")
        {
            _audioSource.Stop();
            _musicLevel.Play();
        }*/
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}