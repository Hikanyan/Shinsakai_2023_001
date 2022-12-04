using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LoadSceneManager : SingletonBehaviour<LoadSceneManager>
{
    private AsyncOperation _async;
    void LoadSeneManager(string sceneName)
    {
        _async = SceneManager.LoadSceneAsync(sceneName);
    }
}
