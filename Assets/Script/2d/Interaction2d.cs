using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction2d : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(Speed, 0));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
