using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// シーンの管理を行う
/// </summary>
public class SceneManager
{
    /// <summary>
    /// SceneManagerの単一インスタンス
    /// </summary>
    public static SceneManager instance { get; private set; }

    /// <summary>
    /// StageManager
    /// </summary>
    public StageManager stageManager { get; set; }

    /// <summary>
    /// コンストラクタ
    /// プロパティの初期化を行う
    /// </summary>
    private SceneManager()
    {
        /* Singleton */

        if (instance == null)
        {
            instance = new SceneManager();
        }
    }

    /// <summary>
    /// StageManagerのstageTypeより適切なJSONファイルのパスを取得する
    /// </summary>
    /// <returns></returns>
    public string GetJsonFilePath()
    {
        return string.Empty;
    }





}
