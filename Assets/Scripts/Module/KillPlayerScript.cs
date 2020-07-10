using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerScript : MonoBehaviour
{
    public static void KillPlayer(TargetEdible targetEd)
    {
        Destroy(targetEd);
    }
}
