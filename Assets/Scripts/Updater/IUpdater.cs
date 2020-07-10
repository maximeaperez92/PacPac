using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;


public abstract class IUpdater : MonoBehaviour
{ 
    public abstract void SystemUpdate();

    public void Start()
    {
        UpdateManager.Instance().AddUpdater(this);
    }
}
