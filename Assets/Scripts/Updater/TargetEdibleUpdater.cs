using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEdibleUpdater : IUpdater
{
    public override void SystemUpdate()
    {
        foreach (var module in TAccessor<TargetEdible>.Instance().GetModules())
        {
            if (!module.fruitTarget)
            {
                module.fruitTarget = GameObject.FindWithTag("Fruit").transform;
            }
        
            transform.LookAt(module.fruitTarget);
            transform.position += transform.rotation * Vector3.forward * 15 * Time.deltaTime;
        }
    }
}
