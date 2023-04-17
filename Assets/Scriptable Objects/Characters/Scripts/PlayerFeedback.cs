using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class PlayerFeedback : MonoBehaviour
{

    public TMP_Text actionTxt;
    public bool flashOver = true;

    void Start()
    {
        actionTxt = actionTxt.GetComponent<TMP_Text>();
    }

    public void WriteToScreen(string txt) 
    {
        actionTxt.text = txt;
    }

    public IEnumerator FlashRed(Image im) 
    {
        flashOver = false;
        im.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        im.color = Color.white;
        flashOver = true;
    }
    public IEnumerator FlashGreen(Image im)
    {
        flashOver = false;
        im.color = Color.green;
        yield return new WaitForSeconds(0.1f);
        im.color = Color.white;
        flashOver = true;
    }
}
