using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMeteorite : MonoBehaviour
{
    void Update()
    {
        if (FindObjectOfType<RunControll>().isRun)
        {
            transform.Rotate(Vector3.right, Space.World);
        }
        
    }
}
