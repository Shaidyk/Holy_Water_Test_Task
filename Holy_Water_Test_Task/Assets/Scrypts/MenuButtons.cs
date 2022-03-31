using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public Button playBtn;
    public Button settingsBtn;
    public Button backBtn;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        settingsBtn.GetComponent<Button>().onClick.AddListener(SettingsOnClick);
        backBtn.GetComponent<Button>().onClick.AddListener(BackOnClick);
    }

    void SettingsOnClick()
    {
        playBtn.enabled = false;
        settingsBtn.enabled = false;
        animator.SetTrigger("Settings");
        if (SFXManager.sfxInstance.sfxToggle)
        {
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.clip);
        }
        
    }

    void BackOnClick()
    {
        playBtn.enabled = true;
        settingsBtn.enabled = true;
        animator.SetTrigger("Menu");
        if (SFXManager.sfxInstance.sfxToggle)
        {
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.clip);
        }
    }

}
