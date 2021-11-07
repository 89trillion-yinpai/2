using UnityEngine;

namespace Assets.Function1.Scripts.Controller
{
    /// 玩家类
    public class PlayerController : HumanBase
    {
        //声明箭的终点坐标，也就是敌人的坐标
        public Transform endTransform;

        //声明玩家
        public GameObject player;

        //声明箭
        public GameObject arrow;

        //动画状态机
        public Animator HeroAni;

        private void Start()
        {
            //从配置表读取数据
            humanList = Duqu.Instance().GetHumanModel();

            //初始化     
            MaxHP = humanList[0].MaxHp;
            CurrentHP = humanList[0].MaxHp;
            Defense = humanList[0].Def;
        }

        private void Update()
        {
            //按下"A"播放攻击动画
            if (Input.GetKeyDown(KeyCode.A))
            {
                HeroAni.Play("Attack");
            }
            //按下"R"播放跑步动画
            else if (Input.GetKeyDown(KeyCode.R))
            {
                HeroAni.Play("Run");
            }
            //松开"R"播放初始状态动画
            else if (Input.GetKeyUp(KeyCode.R))
            {
                HeroAni.SetTrigger("lde");
            }
            //按下"I"播放初始状态动画
            else if (Input.GetKeyDown(KeyCode.I))
            {
                HeroAni.Play("ldle");
            }
        }

        //射箭回调函数 攻击动画事件触发
        public void AnimationCallBack()
        {
            //生成箭的实例
            GameObject go = GameObject.Instantiate(arrow);
            //箭生成的位置在玩家面前
            go.transform.position = player.transform.position + new Vector3(0, 5f, 6f);
        }
    }
}