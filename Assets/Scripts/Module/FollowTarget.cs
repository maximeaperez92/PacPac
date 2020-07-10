using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    private int moveSpeed = 10;
    
    void Start()
    {
        TAccessor<FollowTarget>.Instance().AddModule(this);
    }

    public void UpdateModule()
    {
        if (!target) target = GameObject.Find("Pacman").transform;
        
        // 10 = moveSpeed
        transform.LookAt(target);
        transform.position += transform.rotation * Vector3.forward * moveSpeed * Time.deltaTime;

        if (Vector3.Distance(transform.position, target.transform.position) < .5f)
        {
            TAccessor<>.Instance().GetModules().RemoveModule();
            Destroy(target.gameObject);
        }
    }
}
