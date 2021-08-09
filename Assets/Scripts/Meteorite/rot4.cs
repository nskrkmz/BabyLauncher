using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot4 : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("rot4.cs");
    }
    void Update()
    {
        if (FindObjectOfType<GameManager>().run)
        {
            transform.Rotate(Vector3.down, Space.World);
        }
            
    }
}
