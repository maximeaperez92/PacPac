using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleModule : MonoBehaviour
{
    
    
    void Start()
    {
        TAccessor<EdibleModule>.Instance().AddModule(this);
    }

    public void UpdateModule()
    {
        TAccessor<TargetEdible> targetEdible = TAccessor<TargetEdible>.Instance();
        
        

        foreach (var targetEd in targetEdible.GetModules())
        {
            if (targetEd.fruitTarget)
            {
                if (Vector3.Distance(transform.position, targetEd.fruitTarget.transform.position) < .1f)
                {
                    Debug.Log("Destruction");
                    Debug.Log(targetEd.fruitTarget.gameObject);
                    Destroy(targetEd.fruitTarget.gameObject);
                }
            }
        }
    }
}
