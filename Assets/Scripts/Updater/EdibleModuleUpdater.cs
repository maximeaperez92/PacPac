using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleModuleUpdater : IUpdater
{
    public override void SystemUpdate()
    {
        foreach (var module in TAccessor<EdibleModule>.Instance().GetModules())
        {

        }
    }
}
