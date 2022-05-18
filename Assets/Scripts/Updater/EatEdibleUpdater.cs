using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatEdibleUpdater : IUpdater
{
    public override void SystemUpdate()
    {
        for (int i = 0; i < TAccessor<EatEdibleScript>.Instance().GetModules().Count; i++)
        {
            TargetEdible  targetEd = TAccessor<TargetEdible>.Instance().GetModule(i);
            Pacman entityPacman = TAccessor<Pacman>.Instance().GetModule(i);
            
            if (Vector3.Distance(targetEd.fruitTarget.position, entityPacman.pacman.position) < .5f)
            {
                // Le pacman mange un fruit
                
                Destroy(targetEd.fruitTarget.gameObject);
            }
        }
    }
}
