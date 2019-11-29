    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastControllerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PrefabExplosion;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject Explo = Instantiate(PrefabExplosion);
                Explo.transform.position = hit.point;
                Destroy(Explo, 2);
            }
        }
    }
}
