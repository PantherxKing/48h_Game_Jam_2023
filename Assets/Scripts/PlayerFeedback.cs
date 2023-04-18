using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class PlayerFeedback : MonoBehaviour
{

    public TMP_Text actionTxt;
    public GameObject charChoices;
    public bool flashOver = true;
    public string playerFeedback;
    public string enemyFeedback;
    public bool txt_on = false;
    public bool enemyActiveText = false;
    public HorsemenBase hb;
    public GameObject nextBut;

    void Awake()
    {
        charChoices.SetActive(true);
        nextBut.SetActive(false);
    }
    void Update()
    {

        hb = GameObject.FindGameObjectWithTag("Enemy").GetComponent<HorsemenBase>();
    }

    public void OnNextButtonBressed()
    {
        if (actionTxt.text.Equals(playerFeedback))
        {
            if (hb.Health > 0)
            {
                hb.Attack();
            }
            WriteToScreen(enemyFeedback);
            enemyActiveText = true;
        }
        else if (actionTxt.text.Equals(enemyFeedback) || enemyActiveText)
        {
            actionTxt.text = "";
            StartCoroutine(WaitForFeedback());
            nextBut.SetActive(false);
            charChoices.SetActive(true);
            enemyActiveText = false;
            StopAllCoroutines();
        }
    }

    public void WriteToScreen(string txt)
    {
        nextBut.SetActive(true);
        charChoices.SetActive(false);
        actionTxt.text = txt;
        StartCoroutine(WaitForFeedback());
    }

    IEnumerator WaitForFeedback()
    {
        yield return new WaitForSeconds(2);
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
