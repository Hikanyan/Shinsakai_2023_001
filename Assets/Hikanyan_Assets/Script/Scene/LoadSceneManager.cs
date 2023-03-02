using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using Hikanyan.Core;

public class LoadSceneManager : AbstractSingleton<LoadSceneManager>
{
    private AsyncOperation _async;
    public void LoadSeneManager(string sceneName)
    {
        _async = SceneManager.LoadSceneAsync(sceneName);
    }
}
