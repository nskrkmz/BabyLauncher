using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("rotatearound.cs");
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().run)
        {
            transform.Rotate(Vector3.up, Space.World);
        }
            
    }
}
