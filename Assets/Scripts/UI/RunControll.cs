using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunControll : MonoBehaviour
{
    public bool isRun;
    public Button btn;
    public Sprite runSprite;
    public Sprite stopSprite;

    

    public void OnButtonClick()
    {
        Debug.Log("RunControll.cs");
        if (btn.image.sprite == runSprite)
        {
            FindObjectOfType<GameManager>().run = false;
            FindObjectOfType<FireControl>().isRun = FindObjectOfType<GameManager>().run;
            btn.image.sprite = stopSprite;
            isRun = false;
        }
        else
        {
            FindObjectOfType<GameManager>().run = true;
            FindObjectOfType<FireControl>().isRun = FindObjectOfType<GameManager>().run;
            btn.image.sprite = runSprite;
            isRun = true;
        }
    }
}
