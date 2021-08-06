using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (FindObjectOfType<RunControll>().isRun)
        {
            transform.Rotate(Vector3.down, Space.World);
        }
            
    }
}
