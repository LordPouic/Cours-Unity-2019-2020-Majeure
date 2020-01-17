using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CoroutineScript : MonoBehaviour
{


    public void Start()
    {
        StartCoroutine(WebService());
    }

    public IEnumerator Coucou()
    {
        Debug.Log("Coucou");
        yield return new WaitForSeconds(3);
        Debug.Log("Coucou Coucou");
    }

    public Transform t1, t2;
    public Transform BlocToMove;
    public float MoveTime;

    public IEnumerator Move()
    {
        float timer = 0;
        while (timer < MoveTime)
        {
            BlocToMove.position = Vector3.Lerp(t1.position, t2.position, timer/MoveTime);
            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }

    public IEnumerator WebService()
    {
        Debug.Log("Web Coucou");
        UnityWebRequest w = new UnityWebRequest("http://www.google.com");
        yield return w;
        Debug.Log(w);

        //Application.OpenURL("http://www.google.com");
    }
}
