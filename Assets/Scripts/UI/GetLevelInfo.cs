using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLevelInfo : MonoBehaviour
{
    public Text textBaby;
    int babyCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        babyCount = FindObjectOfType<LevelInfo1>().NumberOfBaby - FindObjectOfType<BabyFire>().shoutCount;
        textBaby.text = babyCount.ToString();
    }
}
