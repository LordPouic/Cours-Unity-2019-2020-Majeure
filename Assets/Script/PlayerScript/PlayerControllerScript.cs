﻿using System.Collections;
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

        int Axe = 0;
        if (Input.GetKey(KeyCode.Z))
            Axe = 1;
        if (Input.GetKey(KeyCode.S))
            Axe = -1;

        Vector3 CurrentSpeed = GetComponent<Rigidbody>().velocity;
        Vector3 MaxSpeed = Axe * Speed * transform.forward;

        GetComponent<Rigidbody>().AddForce(MaxSpeed - CurrentSpeed);

        float Xaxis = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, Xaxis * DelatRot, 0));


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
