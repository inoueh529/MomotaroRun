using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// 敵キャラクターのファクトリークラス
/// </summary>
public class OrgaFactory
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="collision"></param>
    /// <returns></returns>
    public BaseOrga create(String tag)
    {
        BaseOrga orga = null;

        switch (tag)
        {
        case TagConstant.NORMAL_ORGA:
            orga = new NormalOrga();
            break;
        case TagConstant.FAST_ORGA:
            orga = new FastOrga();
            break;
        }

        return orga;
    }
}
