using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WarriorCOntrollerScript : MonoBehaviour
{
    [SerializeField]
    private Transform Target;

    void Start()
    {
        GotoTarget();
    }

    void Update()
    {
        float Speed = Vector3.Magnitude( GetComponent<NavMeshAgent>().velocity );
        GetComponentInChildren<Animator>().SetFloat("Speed", Speed);

        if (GetComponent<NavMeshAgent>().remainingDistance < 4)
            GetComponentInChildren<Animator>().SetTrigger("Attack");

        GotoTarget();

    }

    private void GotoTarget()
    {
        GetComponent<NavMeshAgent>().SetDestination(Target.position);
    }
}
