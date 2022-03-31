using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //public int scene;

    private bool _isLoading;

    private static SceneLoader _instance;

    public GameObject fader;
    Slider loadBar;

    private void Awake()
    {
        //if (_instance != null && _instance != this)
        //{
        //    Destroy(this.gameObject);
        //    return;
        //}

        _instance = this;
        DontDestroyOnLoad(this);
    }

    public void LoadScene(int scene)
    {
        if (_isLoading)
        {
            return;
        }

        if (SFXManager.sfxInstance.sfxToggle)
        {
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.clip);
        }

        StartCoroutine(LoadSceneRutine(scene));

        loadBar = fader.GetComponentInChildren<Slider>();
    }

    private IEnumerator LoadSceneRutine(int scene)
    {
        _isLoading = true;
        var waitFading = true;
        Fader.instance.FadeIn(() => waitFading = false);

        while(waitFading)
            yield return null;

        var async = SceneManager.LoadSceneAsync(scene);
        async.allowSceneActivation = false;

        while(!async.isDone)
        {
            loadBar.value = async.progress;
            if (async.progress >= 0.9f && !async.allowSceneActivation)
            {
                async.allowSceneActivation = true;
            }
            yield return null;
        }

        //while (async.progress < 0.9f)
        //{
        //    loadBar.value = async.progress;
        //    yield return null;
        //}

        //async.allowSceneActivation = true;

        waitFading = true;
        Fader.instance.FadeOut(() => waitFading = false);

        while (waitFading)
            yield return null;

        _isLoading = false;
    }
}
