using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EdibleModule : MonoBehaviour
{
    [SerializeField] private GameObject fruit;
    
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
                    Destroy(targetEd.fruitTarget.gameObject);
                    
                    Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
                    GameObject newFruit = Instantiate(fruit, position, Quaternion.identity);
                    targetEd.fruitTarget = newFruit.transform;
                }
            }
        }
    }
}
