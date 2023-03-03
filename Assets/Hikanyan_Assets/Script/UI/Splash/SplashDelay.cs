using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Hikanyan.Runner
{
    public class SplashDelay : MonoBehaviour
    {
        [SerializeField]
        GameObject _title;
        [SerializeField]
        GameObject _splashCRI;
        private void Awake()
        {
            _title.SetActive(false);
            _splashCRI.SetActive(false);
        }
        async void Start()
        {
            await UniTask.Delay(TimeSpan.FromSeconds(2), true);
            _splashCRI.SetActive(true);
            await UniTask.Delay(TimeSpan.FromSeconds(3), true);
            _splashCRI.SetActive(false);
            _title.SetActive(true);
            GameManager.Instance.GameTitle = true;
        }
    }
}