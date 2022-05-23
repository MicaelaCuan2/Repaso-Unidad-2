using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromScript : MonoBehaviour
{
    public float xSpeed;
    public float xRightLimit;
    public float xLeftLimit;

    public bool toRight;

    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject baseDer;
    public GameObject baseIzq;

    void Start()
    {
        toRight = true;
    }

    void Update()
    {
        if (toRight)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x >= xRightLimit)
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = baseDer.transform.position + new Vector3(0, 1, 0);
        }
        else if (transform.position.x <= xLeftLimit)
        {
            toRight = true;
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = baseIzq.transform.position + new Vector3(0, 1, 0);
        }
    }
}
