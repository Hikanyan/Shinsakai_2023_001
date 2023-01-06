using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Hikanyan.Core;
using System;

namespace Hikanyan.Runner
{
    //[Serializable]
    public class SequenceManager : SingletonBehaviour<SequenceManager>
    {
        [SerializeField,Tooltip("Singleton���g��Manager������")]
        GameObject[] _preloadedAssets;
        [SerializeField,Tooltip("")]


        SceneController _sceneController;

        /// <summary>
        /// ������
        /// </summary>
        public void Initialize()
        {
            _sceneController = new SceneController(SceneManager.GetActiveScene());
            InstantiatePreloadedAssets();
        }

        /// <summary>
        /// PreloadedAssets��S�ăC���X�^���X��
        /// </summary>
        void InstantiatePreloadedAssets()
        {
            foreach (var asset in _preloadedAssets)
            {
                Instantiate(asset);
            }
        }
    }
}