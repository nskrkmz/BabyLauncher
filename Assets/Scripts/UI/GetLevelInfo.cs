using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLevelInfo : MonoBehaviour
{
    public Text textBaby;
    int babyCount;

    private void Start()
    {
        Debug.Log("GetLevelInfo.cs");
    }
    // Update is called once per frame
    void Update()
    {
        Info();
    }

    public int Info()
    {
        babyCount = FindObjectOfType<LevelInfo1>().NumberOfBaby - FindObjectOfType<BabyFire>().shoutCount;
        textBaby.text = babyCount.ToString();
        return babyCount;
    }
}
