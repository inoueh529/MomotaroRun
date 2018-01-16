using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class Player : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
	public void Start () {
		
	}

    /// <summary>
    /// 
    /// </summary>
	public void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swing();
        }
	}

    /// <summary>
    /// 
    /// </summary>
    private void Swing()
    {

    }
}
