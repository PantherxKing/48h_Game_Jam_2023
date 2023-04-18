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
    bool enemyActiveText = false;
    public HorsemenBase hb;
    public Button nextBut;

    void Awake()
    {
        charChoices.SetActive(true);
    }
    private void Start()
    {
        hb = GameObject.FindGameObjectWithTag("Enemy").GetComponent<HorsemenBase>();
    }

    public void OnNextButtonBressed()
    {
        if (actionTxt.text.Equals(playerFeedback))
        {
            WriteToScreen(enemyFeedback);
            enemyActiveText = true;
        }
        else if (enemyActiveText)
        {
            actionTxt.text = "";
            StartCoroutine(WaitForFeedback());
            charChoices.SetActive(true);
            enemyActiveText = false;
        }
    }

    public void WriteToScreen(string txt)
    {
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
