using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombeScript : MonoBehaviour
{
    private List<GameObject> ObjectsInRange = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ennemis")
        {
            ObjectsInRange.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ennemis")
        {
            ObjectsInRange.Remove(other.gameObject);
        }
    }
}
