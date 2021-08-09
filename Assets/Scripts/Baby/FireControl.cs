using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FireControl : MonoBehaviour
{
    bool overButton = false;
      
    public bool fire;

    public bool isRun;
    


    private void Start()
    {
        Debug.Log("FireControl.cs");
        isRun = true;
    }

    private void Update()
    {
        if (FindObjectOfType<GameManager>().run)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                fire = true;
            }
            else
            {
                fire = false;
            }
        }
    }

    

    
}
