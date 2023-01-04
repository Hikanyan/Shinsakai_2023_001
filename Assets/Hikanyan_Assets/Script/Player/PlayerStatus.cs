using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatus", menuName = "CreatePlayerStatus")]
public class PlayerStatus : ScriptableObject
{
    [SerializeField, Tooltip("���x��")]
    int _level;
    [SerializeField, Tooltip("HP���")]
    int _maxHp;
    [SerializeField, Tooltip("�U����")]
    int _attack;
    [SerializeField, Tooltip("�h���")]
    int _defense;
    [SerializeField, Tooltip("�X�^�~�i")]
    int _maxStamina;

    [SerializeField, Tooltip("��S��")]
    float _criticalRate;
    [SerializeField, Tooltip("��S�_���[�W")]
    float _criticalDamage;

    public int SetHp(int hp)
    {
        if (hp <= 0)
        {
            hp = 0;
        }
        this._maxHp = hp;
        return this._maxHp;
    }

    public int GetHp()
    {
        return this._maxHp;
    }

    public void Reset()
    {
        this._maxHp = 10;
    }
}