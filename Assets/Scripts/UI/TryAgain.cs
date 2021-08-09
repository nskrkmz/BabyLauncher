using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void BtnTryAgain()
    {
        Debug.Log("TryAgain.cs");
        FindObjectOfType<GameManager>().SetRun(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        FindObjectOfType<GameManager>().levelPanel.SetActive(true);
        FindObjectOfType<GameManager>().losePannel.SetActive(false);
        
        FindObjectOfType<GameManager>().winPanel.SetActive(false);
        FindObjectOfType<GameManager>().entryPanel.SetActive(false);
        
        FindObjectOfType<RunControll>().isRun = FindObjectOfType<GameManager>().SetRun(true);
    }
}
