using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot4 : MonoBehaviour
{
    void Update()
    {
        if (FindObjectOfType<RunControll>().isRun)
        {
            transform.Rotate(Vector3.down, Space.World);
        }
            
    }
}
