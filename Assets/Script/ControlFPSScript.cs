using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFPSScript : MonoBehaviour
{
    [SerializeField]
    private float Speed;
    [SerializeField]
    private float RotationSpeed;
    [SerializeField]
    private float MaxAngleRotationY;
    [SerializeField]
    [Range(0, 500)]
    private float JumpForce;

    private int NbColliderInTrigger = 0;

    private Rigidbody r;

    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    void Update()
    {


        float DeltaSpeed = Speed * Time.deltaTime;
        float DelatRot = RotationSpeed * Time.deltaTime;

        int Axe = 0;
        if (Input.GetKey(KeyCode.Z))
            Axe = 1;
        if (Input.GetKey(KeyCode.S))
            Axe = -1;

        Vector3 CurrentSpeed = r.velocity;
        Vector3 MaxSpeed = Axe * Speed * transform.forward;

        r.AddForce(MaxSpeed - CurrentSpeed);

        float Xaxis = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, Xaxis * DelatRot, 0));
        float Yaxis = Input.GetAxis("Mouse Y");
        Camera.main.transform.Rotate(new Vector3(-Yaxis * DelatRot, 0, 0));        


        if (Input.GetKeyDown(KeyCode.Space) && NbColliderInTrigger > 0)
            r.AddForce(new Vector3(0, JumpForce, 0));

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
