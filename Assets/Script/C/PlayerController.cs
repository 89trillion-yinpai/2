using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

/// 玩家管理类


public class PlayerController : HumanBase
{
    //声明箭的终点坐标，也就是敌人的坐标
    public Transform endTransform;
    //声明玩家
    public GameObject selfPlayer;
    //声明箭
    public GameObject arrow;
    //射箭起点
    public Transform ShootPoint;

    //动画状态机
    public Animator HeroAni;
    
    private void Start()
    {
        //从配置表读取数据
        humanList = Duqu.Instance().GetHumanModel();

        //初始化     
        MaxHP = humanList[0].MaxHp;
        CurrentHP = humanList[0].MaxHp;
        Attack = humanList[0].Atk;
        Defense = humanList[0].Def;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            HeroAni.Play("Attack");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            HeroAni.Play("Run");
        }
        else if(Input.GetKeyUp(KeyCode.R))
        {
            HeroAni.SetTrigger("lde");
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            HeroAni.Play("ldle");
        }
    }

    //射箭 攻击动画事件触发
    public  void AnimationCallBack()
        {
            GameObject go = GameObject.Instantiate(arrow);
            go.transform.position = selfPlayer.transform.position + new Vector3(0,5f,6f);
            
        }
    }