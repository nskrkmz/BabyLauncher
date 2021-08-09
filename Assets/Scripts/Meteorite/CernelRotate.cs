using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CernelRotate : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("cerrot.cs");
    }
    void Update()
    {
        if (FindObjectOfType<GameManager>().run)
        {
            transform.Rotate(Vector3.left / 3, Space.World);
        }
            
    }
}
