using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 箭管理类
public class ArrowController : MonoBehaviour
{
    //箭飞行速度
    private float speed;

    //箭伤害值
    private float damage = 500f;

    public float Speed
    {
        get { return speed; }

        set { speed = value; }
    }

    public float Damage
    {
        get { return damage; }

        set { damage = value; }
    }

    //每次攻击结束后销毁箭
    private void Start()
    {
        Destroy(this.gameObject, 3f);
    }

    void Update()
    {
        //箭攻击方向
        transform.Translate((Vector3.forward + new Vector3(90, 0, 0)) * Time.deltaTime * 2f);
    }
}