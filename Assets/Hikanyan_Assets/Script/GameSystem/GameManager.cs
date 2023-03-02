using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UniRx;
using Cysharp.Threading.Tasks;
using Hikanyan.Core;
using System.Threading.Tasks;

//UniRx�́u�񓯊������v�Ɓu�C�x���g�����v��2���������Ƃ��ł��郉�C�u�����ł��B
//���Ɂu���ԁv�̈����ɒ����Ă���AUnity�ɂ�����u�t���[�����܂����������v�Ȃǂ̎������ȒP�ɂȂ�܂��B
//UniTask�͔񓯊������̌��ʒʒm���u1��v�ōςޏꍇ
//���ʒʒm��1��ł���A�܂�͒P���Ŋ������镁�ʂ̔񓯊������̏ꍇ�ł��B
//�������UniTask�i��async / await�j���g���ׂ��ł��B
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