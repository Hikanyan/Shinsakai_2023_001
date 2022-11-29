using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/// <summary>プレイヤーを動かす為のコンポーネント</summary>

public class PlayerController : MonoBehaviour
{
    /// <summary>プレイヤースピード</summary>
    [SerializeField]int  _playerSpeed;

    /// <summary>持っているアイテムのリスト</summary>
    List<ItemBase> _itemList = new();


    Rigidbody _rb;

    /// <summary>前進入力の入力値を入れる変数</summary>
    float _horizontal;

    /// <summary>左右入力の入力値を入れる変数</summary>
    float _vertical;

    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
    }
}
