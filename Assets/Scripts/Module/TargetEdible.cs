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

    public void UpdateModule()
    {
        if (!fruitTarget)
        {
            fruitTarget = GameObject.FindWithTag("Fruit").transform;
        }
        
        transform.LookAt(fruitTarget);
        transform.position += transform.rotation * Vector3.forward * moveSpeed * Time.deltaTime;
    }
}
