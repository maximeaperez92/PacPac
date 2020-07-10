using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EdibleModule : MonoBehaviour
{
    [SerializeField] public GameObject fruit;
    
    void Start()
    {
        TAccessor<EdibleModule>.Instance().AddModule(this);
    }

    public void deleteModule()
    {
        TAccessor<EdibleModule>.Instance().RemoveModule(this);
    }

    
}
