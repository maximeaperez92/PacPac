using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatEdibleScript : MonoBehaviour
{

    public void Start()
    {
        TAccessor<EatEdibleScript>.Instance().AddModule(this);
    }
    
    public void deleteModule()
    {
        TAccessor<EatEdibleScript>.Instance().RemoveModule(this);
    }
}
