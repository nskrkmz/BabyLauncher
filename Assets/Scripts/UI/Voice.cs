using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Voice : MonoBehaviour
{
    public Sprite offSprite;
    public Sprite onSprite;
    public Button btn;


    
    public void OnButtonClick()
    {
        if (btn.image.sprite == onSprite)
        {
            btn.image.sprite = offSprite;
        }

        else
        {
            btn.image.sprite = onSprite;
        }
    }


    
}
