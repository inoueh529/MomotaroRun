using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using SimpleJson;
using UnityEngine;

/// <summary>
/// ステージを生成するクラス
/// </summary>
public class StageFactory
{
    /// <summary>
    /// StageFactoryの単一インスタンス
    /// </summary>
    public static StageFactory instance { get; private set; }

    /// <summary>
    /// JSONから読み込んだステージデータ
    /// </summary>
    public StageConfig stageConfig { private get; set; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private StageFactory()
    {
        /* Singleton */

        if (instance == null)
        {
            instance = new StageFactory();
        }
    }

    /// <summary>
    /// ステージの初期状態を設定する
    /// </summary>
    public void Init()
    {

    }

    /// <summary>
    /// ステージを最後尾に追加する
    /// </summary>
    public void CreateStage()
    {

    }

}
