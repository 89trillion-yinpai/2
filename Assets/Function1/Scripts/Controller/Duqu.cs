using System;
using System.Collections.Generic;
using Model;
using TableConfig;
using UnityEngine;

public class Duqu : MonoBehaviour
{
    //单例模式
    private static Duqu instance;

    public static Duqu Instance()
    {
        return instance;
    }

    void Awake()
    {
        instance = this;
    }

    #region HumanModel

    //成对读取数据
    private ITable2Data<HumanModel> humanModelTable;
    private List<HumanModel> humanModel;

    private ITable2Data<HumanModel> HumanModelTable =>
        humanModelTable ?? (humanModelTable = new TableManager<HumanModel>());

    public List<HumanModel> GetHumanModel()
    {
        return humanModel ?? (humanModel = HumanModelTable.GetAllModel());
    }

    public HumanModel GetHumanModel(int id)
    {
        var humanModelDic = GetHumanModelDic();

        if (humanModelDic != null && humanModelDic.ContainsKey(id))
        {
            return humanModelDic[id];
        }

        return null;
    }

    private Dictionary<int, HumanModel> HumanModelDic;

    public Dictionary<int, HumanModel> GetHumanModelDic()
    {
        if (HumanModelDic == null)
        {
            HumanModelDic = new Dictionary<int, HumanModel>();
            List<HumanModel> list = GetHumanModel();
            foreach (var item in list)
            {
                HumanModelDic.Add(item.id, item);
            }
        }

        return HumanModelDic;
    }

    #endregion
}