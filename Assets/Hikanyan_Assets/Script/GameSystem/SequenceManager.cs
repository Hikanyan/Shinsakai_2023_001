using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Hikanyan.Core;

namespace Hikanyan.Runner
{
    public class SequenceManager : SingletonBehaviour<SequenceManager>
    {
        [SerializeField]
        GameObject[] _preloadedAssets;

        SceneController _sceneController;

        public void Initialize()
        {

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