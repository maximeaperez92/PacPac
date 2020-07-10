using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour
{
    private static UpdateManager _instance;
    private List<IUpdater> _updaters;

    public static UpdateManager Instance()
    {
        if (_instance == null)
        {
            _instance = new UpdateManager();
        }

        return _instance;
    }

    private UpdateManager()
    {
        _updaters = new List<IUpdater>();
    }

    public List<IUpdater> GetUpdaters()
    {
        return _updaters;
    }

    public void AddUpdater(IUpdater updater)
    {
        _updaters.Add(updater);
    }


    private void Update()
    {
        foreach (var updater in Instance().GetUpdaters())
        {
            updater.SystemUpdate();
        }
    }
}
