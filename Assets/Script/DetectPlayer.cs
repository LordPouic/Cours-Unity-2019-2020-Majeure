using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public MonoBehaviour Script;
    public string Tag;

    private void Start()
    {
        Script.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tag)
        {
            Script.enabled = true;
        }
    }
}
