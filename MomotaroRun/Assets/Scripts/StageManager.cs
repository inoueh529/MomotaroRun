using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Stageの管理をするクラス
/// </summary>
public class StageManager
{
    /// <summary>
    /// ステージタイプ
    /// </summary>
    public string stageType { get; set; }

    /// <summary>
    /// StageFactory
    /// </summary>
    private StageFactory factory;

    /// <summary>
    /// コンストラクタ
    /// メンバの初期化を行う
    /// </summary>
    public StageManager()
    {
        factory = StageFactory.instance;
        
        SceneManager.instance.stageManager = this;
    }

    /// <summary>
    /// ステージの初期化を行う
    /// </summary>
    private void InitStage()
    {

    }

    /// <summary>
    /// ステージを生成する
    /// </summary>
    public void CreateStage()
    {

    }
}