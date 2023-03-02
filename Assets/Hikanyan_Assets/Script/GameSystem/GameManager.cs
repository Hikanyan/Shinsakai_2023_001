using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UniRx;
using Cysharp.Threading.Tasks;
using Hikanyan.Core;
using System.Threading.Tasks;

//UniRxは「非同期処理」と「イベント処理」の2つを扱うことができるライブラリです。
//特に「時間」の扱いに長けており、Unityにおける「フレームをまたいだ処理」などの実装が簡単になります。
//UniTaskは非同期処理の結果通知が「1回」で済む場合
//結果通知が1回である、つまりは単発で完了する普通の非同期処理の場合です。
//こちらはUniTask（とasync / await）を使うべきです。
namespace Hikanyan.Runner
{
    public class GameManager : AbstractSingleton<GameManager>
    {
        public bool GameTitle = false;
        public bool GameStart = false;
        public bool GameEnd = false;
        public bool GameClear = false;
        public bool GameOver = false;
        protected override void OnAwake()
        {
            TitleGame();
            StartGame();
            Debug.Log("neko");
        }

        async Task TitleGame()
        {
            await UniTask.WaitUntil(() => GameTitle);

            CRIAudioManager.Instance.CRILoopBGM(1,true);
        }
        async Task StartGame()
        {
            await UniTask.WaitUntil(() => GameStart);
            Debug.Log("InGame");
            LoadSceneManager.Instance.LoadSeneManager("InGame");
        }

    }
}