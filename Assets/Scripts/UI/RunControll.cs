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

    private void Start()
    {
        isRun = true;
    }

    public void OnButtonClick()
    {
        if (btn.image.sprite == runSprite)
        {
            FindObjectOfType<FireControl>().isRun = false;
            btn.image.sprite = stopSprite;
            isRun = false;
        }
        else
        {
            FindObjectOfType<FireControl>().isRun = true;
            btn.image.sprite = runSprite;
            isRun = true;
        }
    }
}
