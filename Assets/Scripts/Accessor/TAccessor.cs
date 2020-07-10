using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TAccessor<T>
{
    private static TAccessor<T> _instance;
    private List<T> _modules;

    public static TAccessor<T> Instance()
    {
        if (_instance == null)
        {
            _instance = new TAccessor<T>();
        }

        return _instance;
    }

    private TAccessor()
    {
        _modules = new List<T>();
    }

    public List<T> GetModules()
    {
        return _modules;
    }

    public void AddModule(T module)
    {
        _modules.Add(module);
    }
}