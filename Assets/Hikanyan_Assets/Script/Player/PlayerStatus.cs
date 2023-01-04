using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatus", menuName = "CreatePlayerStatus")]
public class PlayerStatus : ScriptableObject
{
    [SerializeField, Tooltip("レベル")]
    int _level;
    [SerializeField, Tooltip("HP上限")]
    int _maxHp;
    [SerializeField, Tooltip("攻撃力")]
    int _attack;
    [SerializeField, Tooltip("防御力")]
    int _defense;
    [SerializeField, Tooltip("スタミナ")]
    int _maxStamina;

    [SerializeField, Tooltip("会心率")]
    float _criticalRate;
    [SerializeField, Tooltip("会心ダメージ")]
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