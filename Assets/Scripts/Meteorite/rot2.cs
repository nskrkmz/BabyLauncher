using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot2 : MonoBehaviour
{
    void Update()
    {
        if (FindObjectOfType<RunControll>().isRun)
        {
            transform.Rotate(Vector3.left, Space.World);
        }
            
    }
}
