using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUpdater : IUpdater
{
    public void SystemUpdate()
    {

        TAccessor<FollowTarget> followTarget = TAccessor<FollowTarget>.Instance();
        TAccessor<TargetEdible> targetEdible = TAccessor<TargetEdible>.Instance();
        TAccessor<EdibleModule> edibleModule = TAccessor<EdibleModule>.Instance();
        

        foreach (var module in followTarget.GetModules())
        {
            module.UpdateModule();
        }

        foreach (var module2 in targetEdible.GetModules())
        {
            module2.UpdateModule();
        }
        
        foreach (var module3 in edibleModule.GetModules())
        {
            module3.UpdateModule();
        }
    }
}
