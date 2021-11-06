using System;
using System.Collections.Generic;
using TableConfig;
using UnityEngine;

// <summary>
// 人物Model
// </summary>
namespace Model
{
    //序列化数据
    [Serializable]
    public class HumanModel : BaseModel
    {
        public int id;
        public string Name;
        public string note;
        public int MaxHp;
        public int Atk;
        public int Def;
        public int ShootSpeed;
       
        public override object Key()
        {
            return id;
        }     
    }
}