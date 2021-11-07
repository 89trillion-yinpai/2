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
        Defense = humanList[0].Def;
        //显示初始血量状态
        SetHPShow();
    }

    //更新血条显示
    private void SetHPShow()
    {
        hpShowSlider.value = CurrentHP / MaxHP;
    }

    //触发事件
    public void OnTriggerEnter(Collider other)
    {
        //箭才能触发事件
        if (other.tag == "Arrow")
        {
            //计算伤害
            CurrentHP -= (other.transform.GetComponent<ArrowController>().Damage - Defense);

            SetHPShow();

            //死亡事件
            if (CurrentHP <= 0)
            {
                CurrentHP = 0;
                //销毁敌人实例
                Destroy(this.gameObject);
                //删除敌人血条
                hpShowSlider.gameObject.SetActive(false);
            }

            //更新文字
            HPText.text = CurrentHP.ToString() + "/" + MaxHP.ToString();
        }
    }
}