﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBOOMScript : MonoBehaviour
{

    public enum BombType { Click, Timer, Touch}

    [SerializeField]
    private BombType Type;
    [SerializeField]
    private int ExplosionPower = 100;
    [SerializeField]
    private float CountdownToExplosion = 0;
    [SerializeField]
    private GameObject PrefabExplosion;

    [Header("Pour le test !!!")]
    public bool isActivated = false;
    public float timer = 0;
    public List<GameObject> ObjInTrigger = new List<GameObject>();

    private void Start()
    {
        if (Type == BombType.Timer)
        {
            isActivated = true;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isActivated = true;
        }

        if (isActivated)
        {
            timer += Time.deltaTime;

            if (timer > CountdownToExplosion)
            {
                Destroy(gameObject);

                GameObject explo = Instantiate(PrefabExplosion);
                explo.transform.position = transform.position;
                explo.transform.localScale = new Vector3(3, 3, 3);
                Destroy(explo, 2);

                foreach(GameObject g in ObjInTrigger)
                {
                    if (g && g.GetComponent<Rigidbody>())
                    {
                        Vector3 dirExplosion = g.transform.position - transform.position;
                        g.GetComponent<Rigidbody>().AddForce(dirExplosion * ExplosionPower);
                    }
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Type == BombType.Touch && collision.gameObject.tag == "Player")
        {
            isActivated = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ennemis")
        {
            ObjInTrigger.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ennemis")
        {
            ObjInTrigger.Remove(other.gameObject);
        }
    }
}
