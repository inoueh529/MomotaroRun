using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵キャラクターのベースクラス
/// </summary>
public abstract class BaseOrga : MonoBehaviour
{

    /// <summary>
    /// 衝突判定フラグ(未衝突時: false, 既衝突時: true)
    /// </summary>
    protected bool hit { get; set; }

    protected Vector3 speed { get;set; }

    /// <summary>
    /// ベースコンストラクタ
    /// 衝突フラグをfalseに設定する
    /// </summary>
    public BaseOrga()
    {
        this.hit = false;
    }

    /// <summary>
    /// キャラクターを挙動させる
    /// デフォルトではUpdate()メソッドにコールされる
    /// </summary>
    public abstract void Move();

    /// <summary>
    /// 衝突判定が起こった際に衝突判定フラグをtrueにする
    /// </summary>
    public void Hit()
    {
        this.hit = true;
    }

    /// <summary>
    /// Playerの剣に衝突した場合の挙動
    /// バットで打たれたように吹き飛び背景を越えたタイミングでインスタンスを消滅する
    /// </summary>
    protected virtual void HitAway()
    {
        Hit();
    }

    /// <summary>
    /// Playerの体に衝突した場合の挙動
    /// インスタンスを消滅する
    /// </summary>
    protected virtual void Vanish()
    {
        Hit();
    }

    /// <summary>
    /// 衝突した時のデフォルトの挙動
    /// </summary>
    /// <param name="collision">衝突オブジェクト</param>
    public virtual void OnCollisionEnter(Collision collision)
    {
        switch (collision.transform.tag)
        {
        case TagConstant.PLAYER_SORD:
            if (!this.hit) HitAway();
            break;
        case TagConstant.PLAYER_BODY:
            if (!this.hit) Vanish();
            break;
        }
    }

    public virtual void Update()
    {
        Move();
    }
}
