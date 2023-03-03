using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hikanyan.Core;
using System;

[RequireComponent(typeof(Button))]
public class HyperCasualButton : MonoBehaviour
{
    [SerializeField]
    protected Button _button;
    [SerializeField]
    SoundID _buttonsoundID = SoundID.None;
    Action _action;

    protected virtual void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }
    protected virtual void OnClick()
    {
        _action?.Invoke();
        PlayButtonSound();
    }
    protected void PlayButtonSound()
    {
        //SoundIDÇÃIntÇéQè∆
        CRIAudioManager.Instance.CRIPlayBGM((int)_buttonsoundID);
    }
}
