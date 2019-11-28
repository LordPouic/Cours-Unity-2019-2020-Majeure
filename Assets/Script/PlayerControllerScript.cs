using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    [SerializeField]
    private float Speed;

    [SerializeField]
    [Range(0,500)]
    private float JumpForce;

    private int NbColliderInTrigger = 0;

    // Update is called once per frame
    void Update()
    {
        float DeltaSpeed = Speed * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().AddForce(new Vector3(DeltaSpeed, 0, 0));

        if (Input.GetKey(KeyCode.Q))
            GetComponent<Rigidbody>().AddForce(-new Vector3(DeltaSpeed, 0, 0));

        if (Input.GetKey(KeyCode.Z))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, DeltaSpeed));

        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().AddForce(-new Vector3(0, 0, DeltaSpeed));

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
