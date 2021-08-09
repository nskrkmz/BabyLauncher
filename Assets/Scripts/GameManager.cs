using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject levelPanel;
    public GameObject losePannel;
    public GameObject winPanel;
    public GameObject entryPanel;
    public int levelCount = 0;

    public bool run;

    private void Awake()
    {
        Debug.Log("GameManager.cs");
        if (SceneManager.GetActiveScene().name == "Level_001" && levelCount == 0)
        {
            entryPanel.SetActive(true);
            levelCount++;
            levelPanel.SetActive(false);
            losePannel.SetActive(false);
            winPanel.SetActive(false);
            run = false;
        }
    }
    void Start()
    {
        
        
    }

    void Update()
    {
        if (levelPanel.active)
        {
            SetRun(true);
        }

        if (GetRun())
        {
            CompleteLevel();
            Restart();
        }
        
    }
    public bool SetRun(bool runSituation)
    {
        this.run = runSituation;
        return GetRun();
    }
    private bool GetRun()
    {
        return this.run;
    }
    public void CompleteLevel()
    {
        if (FindObjectOfType<TimePrinter>().TimePrint()> 0 && FindObjectOfType<GetLevelInfo>().Info() <= 0)
        {
            run = false;
            levelPanel.SetActive(false);
            losePannel.SetActive(false);
            entryPanel.SetActive(false);
            winPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && FindObjectOfType<CurrentShotClock>().isClockRun && FindObjectOfType<BabyFire>().shoutCount > 2)
        {
            Debug.Log("if1");
            run = false;
            levelPanel.SetActive(false);
            entryPanel.SetActive(false);
            winPanel.SetActive(false);
            losePannel.SetActive(true);
        }

        if (FindObjectOfType<LevelInfo1>().LevelTime - Time.time <= 0 && FindObjectOfType<GetLevelInfo>().Info() > 0)
        {
            Debug.Log("if2");
            Debug.Log(FindObjectOfType<LevelInfo1>().LevelTime);
            Debug.Log(FindObjectOfType<TimePrinter>().TimePrint());
            Debug.Log(FindObjectOfType<GetLevelInfo>().Info());
            run = false;
            levelPanel.SetActive(false);
            entryPanel.SetActive(false);
            winPanel.SetActive(false);
            losePannel.SetActive(true);
        }
    }
}
