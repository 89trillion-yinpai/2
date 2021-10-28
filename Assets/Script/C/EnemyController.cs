using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 敌人控制类
/// </summary>
public class EnemyController : HumanBase
{
    public Slider hpShowSlider;
    
    private void Start()
    {
        //从配置表读取数据
        humanList = Duqu.Instance().GetHumanModel();

        //初始化     
        MaxHP = humanList[0].MaxHp;
        CurrentHP = humanList[0].MaxHp;
        Attack = humanList[0].Atk;
        Defense = humanList[0].Def;
        SetHPShow();
    }

    //更新血条显示
    private void SetHPShow()
    {
        hpShowSlider.value = CurrentHP / MaxHP;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Arrow")
        {
            //计算伤害
            CurrentHP -= (other.transform.GetComponent<ArrowController>().Damage-Defense);

            SetHPShow();
            
            //死亡
            if(CurrentHP<=0)
            {
                CurrentHP = 0;
                Destroy(this.gameObject); 
                hpShowSlider.gameObject.SetActive(false);
            }
            //更新文字
            HPText.text = CurrentHP.ToString() + "/" + MaxHP.ToString();
        }
    }
}