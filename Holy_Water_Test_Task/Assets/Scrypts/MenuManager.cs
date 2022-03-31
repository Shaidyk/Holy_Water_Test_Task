using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Toggle sFXToggle;
    public Toggle musicToggle;

    private void Start()
    {
        //SFX toggle toggle
        if (SFXManager.sfxInstance.sfxToggle)
        {
            sFXToggle.isOn = true;
            SFXManager.sfxInstance.sfxToggle = true;
        }
        else
        {
            sFXToggle.isOn = false;
            SFXManager.sfxInstance.sfxToggle = false;
        }

        //Music toggle
        if (BackgroundMusic.backgroundMusic.musicToggle)
        {
            musicToggle.isOn = true;
            BackgroundMusic.backgroundMusic.audioSource.Play();
            BackgroundMusic.backgroundMusic.musicToggle = true;
        }
        else
        {
            musicToggle.isOn = false;
            BackgroundMusic.backgroundMusic.audioSource.Pause();
            BackgroundMusic.backgroundMusic.musicToggle = false;
        }
    }


    public void SFXToggleOnClick()
    {
        if (SFXManager.sfxInstance.sfxToggle)
        {
            SFXManager.sfxInstance.sfxToggle = false;
        }
        else
        {
            SFXManager.sfxInstance.sfxToggle = true;
        }
        Debug.Log(SFXManager.sfxInstance.sfxToggle);
    }

    public void MusicToggleOnClick()
    {
        if (BackgroundMusic.backgroundMusic.audioSource.isPlaying)
        {
            BackgroundMusic.backgroundMusic.audioSource.Pause();
            BackgroundMusic.backgroundMusic.musicToggle = false;
        }
        else
        {
            BackgroundMusic.backgroundMusic.audioSource.Play();
            BackgroundMusic.backgroundMusic.musicToggle = true;
        }
    }
}
