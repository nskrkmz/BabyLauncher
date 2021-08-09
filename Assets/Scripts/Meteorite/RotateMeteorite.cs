using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMeteorite : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Rotmet.cs");
    }
    void Update()
    {
        if (FindObjectOfType<GameManager>().run)
        {
            transform.Rotate(Vector3.right, Space.World);
        }
        
    }
}
