using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/// <summary>�v���C���[�𓮂����ׂ̃R���|�[�l���g</summary>

public class PlayerController : MonoBehaviour
{
    /// <summary>�v���C���[�X�s�[�h</summary>
    [SerializeField]int  _playerSpeed;

    /// <summary>�����Ă���A�C�e���̃��X�g</summary>
    List<ItemBase> _itemList = new();


    Rigidbody _rb;

    /// <summary>�O�i���͂̓��͒l������ϐ�</summary>
    float _horizontal;

    /// <summary>���E���͂̓��͒l������ϐ�</summary>
    float _vertical;

    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
    }
}
