using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{
    public Button menuBtn;

    void Start()
    {
        menuBtn.GetComponent<Button>().onClick.AddListener(MenuOnClick);
    }

    void MenuOnClick()
    {
        SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.clip);
        SceneManager.LoadScene(0);
    }
}
