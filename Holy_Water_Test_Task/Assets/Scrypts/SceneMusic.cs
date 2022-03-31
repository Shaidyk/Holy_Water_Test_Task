using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMusic : MonoBehaviour
{
    void Start()
    {
        var numScene = SceneManager.GetActiveScene().buildIndex;
        BackgroundMusic.backgroundMusic.audioSource.clip = BackgroundMusic.backgroundMusic.clips[numScene];
        if (BackgroundMusic.backgroundMusic.musicToggle)
            BackgroundMusic.backgroundMusic.audioSource.Play();
    }
}
