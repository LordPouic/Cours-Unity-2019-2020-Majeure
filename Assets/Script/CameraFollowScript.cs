using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    [SerializeField]
    private Transform Target1;
    [SerializeField]
    private Transform Target2;
    [SerializeField]
    private float CameraSpeed;
    [SerializeField]
    private float DeltaHeight;
    [SerializeField]
    private float MinDistance,Maxdistance;

    void Update()
    {
        Vector3 Middle = Vector3.Lerp(Target1.position, Target2.position, 0.5f);
        float distance = Vector3.Distance(Target1.position, Target2.position);

        if (distance > Maxdistance)
            distance = Maxdistance;
        if (distance < MinDistance)
            distance = MinDistance;

        Vector3 t = Middle + new Vector3(0, distance + DeltaHeight, 0);

        transform.position = Vector3.Lerp(transform.position, t , Time.deltaTime * CameraSpeed);
    }
}
