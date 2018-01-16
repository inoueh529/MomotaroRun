using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class BaseStage : MonoBehaviour
{
    protected Vector3 speed;
    protected abstract void RunStage();

    public virtual void Update()
    {
        RunStage();
    }
}
