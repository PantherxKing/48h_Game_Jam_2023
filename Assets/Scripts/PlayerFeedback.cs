using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class PlayerFeedback : MonoBehaviour
{

    public TMP_Text actionTxt;
    public LayoutGroup charChoices;
    public bool flashOver = true;

    void Start()
    {
        actionTxt.gameObject.SetActive(false);
        charChoices.gameObject.SetActive(true);
        actionTxt = actionTxt.GetComponent<TMP_Text>();
    }

    public void WriteToScreen(string txt) 
    {
        charChoices.gameObject.SetActive(false);
        actionTxt.gameObject.SetActive(true);
        actionTxt.text = txt;
        StartCoroutine(WaitForFeedback());
        StopCoroutine(WaitForFeedback());

    }

    IEnumerator WaitForFeedback() 
    {
        yield return new WaitForSeconds(2);
        actionTxt.gameObject.SetActive(false);
        charChoices.gameObject.SetActive(true);
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
