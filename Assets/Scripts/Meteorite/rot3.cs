using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot3 : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("rot3.cs");
    }
    // Start is called before the first frame update
    void Update()
    {
        if (FindObjectOfType<GameManager>().run)
        {
            transform.Rotate(Vector3.down, Space.World);
        }
            
    }
}
