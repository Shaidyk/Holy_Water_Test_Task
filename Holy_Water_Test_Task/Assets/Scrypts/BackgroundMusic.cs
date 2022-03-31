using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic backgroundMusic;
    public AudioSource audioSource;
    public AudioClip[] clips;

    public bool musicToggle = true;

    private void Awake()
    {
        
        if (backgroundMusic != null && backgroundMusic != this)
        {
            Destroy(this.gameObject);
            return;
        }

        backgroundMusic = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
