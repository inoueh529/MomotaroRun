using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleJson;
using UnityEngine;
using System.IO;

/// <summary>
/// Jsonファイルを読み込みClassオブジェクトに変換するシングルトンクラス
/// </summary>
public class JsonConverter
{
    /// <summary>
    /// JsonConverterの単一インスタンス
    /// </summary>
    public static JsonConverter instance { get; private set; }

    /// <summary>
    /// コンストラクタ
    /// JsonConverterの単一インスタンスの初期化を行う
    /// </summary>
    private JsonConverter()
    {
        /* Singleton */

        if (instance == null)
        {
            instance = new JsonConverter();
        }
    }

    /// <summary>
    /// 指定のJsonファイルをStageConfigにデシリアライズする
    /// </summary>
    /// <param name="filePath">Jsonファイルのパス</param>
    /// <returns>StageConfigのインスタンス</returns>
    public StageConfig ToObject(string filePath)
    {
        StageConfig config = null;

        return config;
    }
}
