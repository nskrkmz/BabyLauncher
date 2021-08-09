using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot2 : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("rot2.cs");
    }
    void Update()
    {
        if (FindObjectOfType<GameManager>().run)
        {
            transform.Rotate(Vector3.left, Space.World);
        }
            
    }
}
