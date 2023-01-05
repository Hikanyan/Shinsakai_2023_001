using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManager : SingletonBehaviour<SequenceManager>
{
    [SerializeField]
    GameObject[] _preloadedAssets;



    public void Initialize()
    {
        InstantiatePreloadedAssets();
    }

    /// <summary>
    /// PreloadedAssetsを全てインスタンス化
    /// </summary>
    void InstantiatePreloadedAssets()
    {
        foreach(var asset in _preloadedAssets)
        {
            Instantiate(asset);
        }
    }
}
