using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemyLifeScript : LifeScript
{
    public override void Death()
    {
        GetComponentInChildren<Animator>().SetTrigger("Death");
        GetComponent<NavMeshAgent>().speed = 0;
    }

    public override void End()
    {
        Destroy(gameObject);
    }
}
