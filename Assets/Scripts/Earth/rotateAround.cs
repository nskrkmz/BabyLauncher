using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<RunControll>().isRun)
        {
            transform.Rotate(Vector3.up, Space.World);
        }
            
    }
}
