using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    
    void Start()
    {
        TAccessor<FollowTarget>.Instance().AddModule(this);
        Debug.Log("Module followTarget ajouté");
    }

    public void UpdateModule()
    {
        if (!target) target = GameObject.Find("Pacman").transform;
        
        // 10 = moveSpeed
        transform.LookAt(target);
        transform.position += transform.rotation * Vector3.forward * 10 * Time.deltaTime;
    }
}
