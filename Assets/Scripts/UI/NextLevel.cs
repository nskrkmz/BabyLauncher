using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void BtnNextLevelAction()
    {
        Debug.Log("NextLevel.cs");
        FindObjectOfType<GameManager>().winPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<GameManager>().levelPanel.SetActive(true);
        FindObjectOfType<GameManager>().SetRun(true);
        FindObjectOfType<GameManager>().losePannel.SetActive(false);
        FindObjectOfType<GameManager>().entryPanel.SetActive(false);
        
        FindObjectOfType<RunControll>().isRun = FindObjectOfType<GameManager>().run;
    }
}
