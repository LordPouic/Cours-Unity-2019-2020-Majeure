using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    [SerializeField]
    private float Speed;
    [SerializeField]
    private float RotationSpeed;

    [SerializeField]
    [Range(0,500)]
    private float JumpForce;

    private int NbColliderInTrigger = 0;

    void Update()
    {
        float DeltaSpeed = Speed * Time.deltaTime;
        float DelatRot = RotationSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(new Vector3(0, DelatRot, 0));

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(new Vector3(0, -DelatRot, 0));

        if (Input.GetKey(KeyCode.Z))
            GetComponent<Rigidbody>().AddForce(transform.forward * DeltaSpeed);

        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().AddForce(-transform.forward * DeltaSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && NbColliderInTrigger>0 )
            GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));


    }

    private void OnTriggerEnter(Collider other)
    {
        NbColliderInTrigger++;
    }

    private void OnTriggerExit(Collider other)
    {
        NbColliderInTrigger--;
    }
}
