using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager : MonoBehaviour
{
    public GameObject myCube;
    public GameObject rotado;
    public GameObject escalado;
    public GameObject rotadoYEscalado;

    Vector3 originalRotation;
    Vector3 originalScale;
    bool isRotated;
    bool isScale;

   void Start()
    {
        isRotated = false;
        isScale = false;
        originalRotation = myCube.transform.eulerAngles;
        originalScale = myCube.transform.localScale;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = originalRotation;
                isRotated = false;
            }
            else
            {
                myCube.transform.eulerAngles = rotado.transform.eulerAngles;
                isRotated = true;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (isScale)
            {
                myCube.transform.localScale = originalScale;
                isScale = false;
            }
            else
            {
                myCube.transform.localScale = escalado.transform.localScale;
                isScale = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (isScale && isRotated)
            {
                myCube.transform.localScale = originalScale;
                myCube.transform.eulerAngles = originalScale;
                isScale = false;
                isRotated = false;
            }
            else
            {
                myCube.transform.localScale = escalado.transform.localScale;
                myCube.transform.eulerAngles = rotado.transform.eulerAngles;
                isRotated = true;
                isScale = true;
            }

        }
    }
}
