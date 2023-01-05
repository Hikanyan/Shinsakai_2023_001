using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Hikanyan.Core
{
    public class SceneController
    {
        Scene _lastScene;
        readonly Scene _neverUnloadScene;
        /// <summary>
        /// �S�Ẵ��x���Ɉˑ����Ȃ��}�l�[�W���[���C���X�^���X�����A
        /// �����ăA�����[�h���Ȃ��V�[��
        /// </summary>
        /// <param name="neverUnloadScene"></param>
        public SceneController(Scene neverUnloadScene)
        {
            _neverUnloadScene = neverUnloadScene;
            _lastScene = _neverUnloadScene;
        }
        public IEnumerator LoadScene(string scene)
        {
            //value �p�����[�^�[�� null �܂��͋�̕����� ("") �̏ꍇ�� true�B����ȊO�̏ꍇ�� false�B
            if (string.IsNullOrEmpty(scene))
            {
                throw new ArgumentException($"{nameof(scene)} is invalid!");
            }
            yield return UnloadLastScene();
            yield return LoadSceneAdditive(scene);
        }
        /// <summary>
        /// �w�肳�ꂽ���O�̐V������̃V�[�����쐬���ă��[�h���A���̃V�[�����A�����[�h���܂��B
        /// </summary>
        /// <param name="scene"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public IEnumerator LoadNewScene(string scene)
        {
            if (string.IsNullOrEmpty(scene))
            {
                throw new ArgumentException($"{nameof(scene)} is invalid!");
            }
            yield return UnloadLastScene();
            LoadNewSceneAdditive(scene);
        }
        /// <summary>
        /// �w�肳�ꂽ���O�Ŏ��s���ɋ�̐V�����V�[�����쐬���܂��B
        /// </summary>
        /// <param name="sceneName"></param>
        void LoadNewSceneAdditive(string sceneName)
        {
            var scene = SceneManager.CreateScene(sceneName);
            SceneManager.SetActiveScene(scene);
            _lastScene = scene;
        }

        /// <summary>
        /// �Ō�Ƀ��[�h���ꂽ�V�[�����A�����[�h���܂�
        /// </summary>
        public IEnumerator UnloadLastScene()
        {
            if (_lastScene != _neverUnloadScene)
            {
                yield return UnloadScene(_lastScene);
            }
        }
        /// <summary>
        /// �w�肳�ꂽ�V�[���Ɋ֘A�t����ꂽ���ׂẴQ�[���I�u�W�F�N�g��j�����A�V�[�����폜���܂��B
        /// </summary>
        /// <param name="scene"></param>
        /// <returns></returns>
        IEnumerator UnloadScene(Scene scene)
        {
            if (!_lastScene.IsValid())//���ꂪ�L���ȃV�[������Ȃ�������
            {
                yield break;
            }

            var asyncUnload = SceneManager.UnloadSceneAsync(scene);
            while (!asyncUnload.isDone)
            {
                yield return null;
            }
        }
        //�V�[�����o�b�N�O���E���h�Ŕ񓯊��Ƀ��[�h���܂��B
        IEnumerator LoadSceneAdditive(string scenePath)
        {
            var asyncLoad = SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Additive);
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
            _lastScene = SceneManager.GetSceneByPath(scenePath);
            SceneManager.SetActiveScene(_lastScene);
        }
    }
}
