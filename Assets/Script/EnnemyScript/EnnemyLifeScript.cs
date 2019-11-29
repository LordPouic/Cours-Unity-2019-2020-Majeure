using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnnemyLifeScript : LifeScript
{
    [SerializeField]
    public Image LifeBar;

    public override void Death()
    {
        GetComponentInChildren<Animator>().SetTrigger("Death");
        GetComponent<NavMeshAgent>().speed = 0;
    }

    public override void End()
    {
        Destroy(gameObject);
    }

    public override void UpdateLife(int nb)
    {
        base.UpdateLife(nb);
        LifeBar.transform.localScale = new Vector3(((float)CurrentLife / (float)MaxLife), 1, 1);
    }
}
