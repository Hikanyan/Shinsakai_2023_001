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
    /// PreloadedAssets��S�ăC���X�^���X��
    /// </summary>
    void InstantiatePreloadedAssets()
    {
        foreach(var asset in _preloadedAssets)
        {
            Instantiate(asset);
        }
    }
}
