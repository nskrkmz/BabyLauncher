using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    [SerializeField]float rotateSpeed = 100;
    public float x;
    public float y;
    public bool isRun = false;
    
    //Vector2 earthMove =new Vector2();


    private void Update()
    {
        EarthMover();
    }

    void EarthMover()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            float rotX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
            x = rotX;
            float rotY = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;
            y = rotY;

            transform.Rotate(Vector3.up, -rotX);
            transform.Rotate(Vector3.right, rotY);
        }
    }

    
}
