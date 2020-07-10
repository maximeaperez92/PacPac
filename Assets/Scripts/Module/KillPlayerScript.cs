using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerScript : MonoBehaviour
{
    private void Start()
    {
        TAccessor<KillPlayerScript>.Instance().AddModule(this);
    }
    
    public void deleteModule()
    {
        TAccessor<KillPlayerScript>.Instance().RemoveModule(this);
    }
}
