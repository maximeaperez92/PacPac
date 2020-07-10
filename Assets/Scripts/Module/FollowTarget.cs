using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private GameObject pacman;
    public Transform target;
    private int moveSpeed = 12;
    
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
            target.gameObject.GetComponent<EdibleModule>().deleteModule();
            target.gameObject.GetComponent<TargetEdible>().deleteModule();
            
            Destroy(target.gameObject);
            
            Vector3 position = new Vector3(Random.Range(-25f, 25f), 0.5f, Random.Range(-25f, 25f));
            GameObject obj = Instantiate(pacman, position, Quaternion.identity);
            
            target = obj.transform;
        }
    }
}
