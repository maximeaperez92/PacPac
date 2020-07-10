using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    public Transform pacman;

    public void Start()
    {
        pacman = transform;
        
        TAccessor<Pacman>.Instance().AddModule(this);
    }
    
    public void deleteModule()
    {
        TAccessor<Pacman>.Instance().RemoveModule(this);
    }
}
