using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CernelRotate : MonoBehaviour
{
    void Update()
    {
        if (FindObjectOfType<RunControll>().isRun)
        {
            transform.Rotate(Vector3.left / 3, Space.World);
        }
            
    }
}
