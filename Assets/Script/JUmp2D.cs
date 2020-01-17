using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUmp2D : MonoBehaviour
{

    public float JumpForce;
    private Rigidbody2D r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            r.AddForce(new Vector2(0, JumpForce));
    }
}
