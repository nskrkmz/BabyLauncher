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
        isRun = true;
    }

    private void Update()
    {
        if (isRun)
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
