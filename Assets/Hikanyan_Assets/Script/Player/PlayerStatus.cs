using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.HighDefinition.ScalableSettingLevelParameter;

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

    public int SetLevel(int lv)
    {
        _level = lv;
        return _level;
    }
    public int GetLevel(int lv)
    {
        return _level;
    }

    public int SetHp(int hp)
    {
        if (hp <= 0)
        {
            hp = 0;
        }
        _maxHp = hp;
        return _maxHp;
    }

    public int GetHp()
    {
        return _maxHp;
    }
    public int SetAttack(int atk)
    {
        _attack = atk;
        return _attack;
    }

    public int GetAttack(int atk)
    {
        return _attack;
    }
    public int SetDefemse(int def)
    {
        _defense = def;
        return _defense;
    }
    public int GetDefense(int def)
    {
        return _defense;
    }
    public int SetStamina(int stamina)
    {
        _maxStamina = stamina;
        return _maxStamina;
    }
    public int GetStamina(int stamina)
    {
        return _maxStamina;
    }
    public float SetCriticalRate(float cr)
    {
        _criticalRate = cr;
        return _criticalRate;
    }
    public float GetCriticalRate(float cr)
    {
        return _criticalDamage;
    }
    public float SetCriticalDamage(float cr)
    {
        _criticalDamage = cr;
        return _criticalDamage;
    }

    public void Reset()
    {
        _level = 1;
        _maxHp = 10;
        _attack = 1;
        _defense = 0;
        _maxStamina = 10;

        _criticalRate = 1.0f;
        _criticalDamage = 1.0f;
    }
}