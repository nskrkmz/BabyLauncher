using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentShotClock : MonoBehaviour
{
    public Image shotClock;
    public bool isClockRun;

    private Vector3 defaultShotClockScale;
    private float defaultY;
    private float defaultZ;
    private float shotClockScaleX;
    private float balancer;
    private Vector3 newScale;
    void Start()
    {
        Debug.Log("CurrentShotClocks.cs");
        isClockRun = false;

        defaultShotClockScale= shotClock.transform.localScale;
        defaultY = shotClock.transform.localScale.y;
        defaultZ = shotClock.transform.localScale.z;

        shotClockScaleX = shotClock.transform.localScale.x;
        balancer = shotClockScaleX / 130;
    }

    void Update()
    {
        if (FindObjectOfType<BabyFire>().isAlive)
        {
            ShotClockRescaler();
        }

        if (!(FindObjectOfType<BabyFire>().isAlive))
        {
            isClockRun = false;
            shotClock.transform.localScale = defaultShotClockScale;
        }
    }

    private void ShotClockRescaler()
    {
        isClockRun = true;
        newScale.x = shotClock.transform.localScale.x - balancer ;
        newScale.y = defaultY;
        newScale.z = defaultZ;
        if(newScale.x > 0)
        {
            shotClock.transform.localScale = newScale;
        }
        
    }



}
