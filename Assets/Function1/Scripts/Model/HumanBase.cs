using System.Collections;
using System.Collections.Generic;
using Model;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 人物基类
/// </summary>
public class HumanBase : MonoBehaviour//人物基础属性类
{
    //最大血量
    private float maxHP;
    //当前血量
    private float currentHP;
    //攻击值
    private float attack;
    //防御值
    private float defense;
    //攻速值
    private float attackSpeed;

    //声明血条
    public Slider HPSlider;
    //血条值
    public Text HPText;
   

    public List<HumanModel> humanList = new List<HumanModel>();

    public float MaxHP
    {
        get
        {
            return maxHP;
        }
        set
        {
            maxHP = value;
        }
    }

    public float CurrentHP
    {
        get
        {
            return currentHP;
        }
        set
        {
            currentHP = value;
        }
    }

    public float Attack
    {
        get
        {
            return attack;
        }
        set
        {
            attack = value;
        }
    }

    public float Defense
    {
        get
        {
            return defense;
        }
        set
        {
            defense = value;
        }
    }

    public float AttackSpeed
    {
        get
        {
            return attackSpeed;
        }
        set
        {
            attackSpeed = value;
        }
    }

}