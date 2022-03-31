using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXManager : MonoBehaviour
{
    public static SFXManager sfxInstance;

    public AudioSource audioSource;
    public AudioClip clip;

    public bool sfxToggle = true;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        DontDestroyOnLoad(this);
    }



    //public static SFXManager _instance;
    //public AudioClip audioClip;
    //public bool muted = false;

    //Button[] buttons;

    //private void Start()
    //{
    //    buttons = FindObjectsOfType<Button>();
    //    foreach (Button btn in buttons)
    //    {
    //        btn.gameObject.AddComponent<AudioSource>();
    //        AudioSource btnAudioSource = btn.GetComponent<AudioSource>();
    //        btnAudioSource.clip = audioClip;
    //        btn.onClick.AddListener(btnAudioSource.Play);
    //    }

    //    if (!PlayerPrefs.HasKey("muted"))
    //    {
    //        PlayerPrefs.SetInt("muted", 0);
    //        Load();
    //    }
    //    else
    //    {
    //        Load();
    //    }

    //}

    //public void SFXToggle()
    //{
    //    if (!SFX.sFX.audioSource.mute)
    //    {
    //        foreach (Button btn in buttons)
    //        {
    //            btn.GetComponent<AudioSource>().mute = true;
    //        }
    //        SFX.sFX.audioSource.mute = true;
    //        muted = true;
    //    }
    //    else
    //    {
    //        foreach (Button btn in buttons)
    //        {
    //            btn.GetComponent<AudioSource>().mute = false;
    //        }
    //        SFX.sFX.audioSource.mute = false;
    //        muted = false;
    //    }

    //    Save();
    //}

    //public void Load()
    //{
    //    muted = PlayerPrefs.GetInt("muted") == 1;
    //}

    //private void Save()
    //{
    //    PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    //}
}
