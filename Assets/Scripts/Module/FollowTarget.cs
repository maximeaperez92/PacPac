using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] public GameObject pacman;
    public Transform target;
    public int moveSpeed = 12;
    
    void Start()
    {
        TAccessor<FollowTarget>.Instance().AddModule(this);
    }
}
