using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEdible : MonoBehaviour
{
    public Transform fruitTarget;
    private int moveSpeed = 15;
    void Start()
    {
        TAccessor<TargetEdible>.Instance().AddModule(this);
    }
    
    public void deleteModule()
    {
        TAccessor<TargetEdible>.Instance().RemoveModule(this);
    }
}
