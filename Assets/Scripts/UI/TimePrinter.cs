using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePrinter : MonoBehaviour
{
    public Text timeText;

    private float time;

    void Start()
    {
        Debug.Log("TimePrinter.cs");
        time = FindObjectOfType<LevelInfo1>().LevelTime;
        timeText.text = time.ToString();
    }

    void Update()
    {
        TimePrint();
    }

    public float TimePrint()
    {
        float currentTime = time - Time.time;
        if (currentTime > 10f)
        {
            timeText.text = (currentTime).ToString("0");
        }
        else if (currentTime<= 0f)
        {
            timeText.text = 0f.ToString();
        }

        else
        {
            timeText.GetComponent<Text>().color = Color.red;
            double txt = Math.Round(currentTime, 2);
            timeText.text = txt.ToString();

        }

        Debug.Log("time :"+ time);
        Debug.Log("FindObjectOfType<LevelInfo1>().LevelTime" + FindObjectOfType<LevelInfo1>().LevelTime);
        Debug.Log("time.time :" + Time.time);
        return time - Time.time;
    }
}
