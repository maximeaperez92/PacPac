using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetUpdater : IUpdater
{
    public override void SystemUpdate()
    {
        foreach (var module in TAccessor<FollowTarget>.Instance().GetModules())
        {
            if (!module.target) module.target = GameObject.Find("Pacman").transform;
        
            // 10 = moveSpeed
            transform.LookAt(module.target);
            transform.position += transform.rotation * Vector3.forward * module.moveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, module.target.transform.position) < .5f)
            {
                module.target.gameObject.GetComponent<EdibleModule>().deleteModule();
                module.target.gameObject.GetComponent<TargetEdible>().deleteModule();
            
                Destroy(module.target.gameObject);
            
                Vector3 position = new Vector3(Random.Range(-25f, 25f), 0.5f, Random.Range(-25f, 25f));
                GameObject obj = Instantiate(module.pacman, position, Quaternion.identity);
            
                module.target = obj.transform;
            }
        }
        
    }
}
