using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 箭管理类
public class ArrowController : MonoBehaviour
{
    //箭飞行速度
    private float speed;

    //箭伤害
    private float damage = 500f;

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    private void Start()
    {
        Destroy(this.gameObject, 3f);
    }

    void Update()
    {
        transform.Translate((Vector3.forward + new  Vector3(90,0,0)) * Time.deltaTime * 2f );
    }
}