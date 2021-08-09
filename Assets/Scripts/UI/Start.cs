using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void BtnStartAction()
    {
        if (SceneManager.GetActiveScene().name == "Level_001")
        {
            Debug.Log("start!1111111");
            FindObjectOfType<GameManager>().entryPanel.SetActive(false);
            FindObjectOfType<GameManager>().levelPanel.SetActive(true);
            FindObjectOfType<GameManager>().losePannel.SetActive(false);
            FindObjectOfType<GameManager>().winPanel.SetActive(false);


            FindObjectOfType<GameManager>().run = true;
            FindObjectOfType<RunControll>().isRun = FindObjectOfType<GameManager>().run;
        }
        else
        {
            Debug.Log("start222222222");
            FindObjectOfType<GameManager>().entryPanel.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            FindObjectOfType<GameManager>().levelPanel.SetActive(true);
            FindObjectOfType<GameManager>().losePannel.SetActive(false);
            FindObjectOfType<GameManager>().winPanel.SetActive(false);


            FindObjectOfType<GameManager>().run = true;
            FindObjectOfType<RunControll>().isRun = FindObjectOfType<GameManager>().run;
        }
    }
}
