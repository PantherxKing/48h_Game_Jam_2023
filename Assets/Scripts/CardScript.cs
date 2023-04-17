using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardScript : MonoBehaviour
{
    [Header("GameObjects")]
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Description;
    public Image Card;
    public Image Icon;
    [Header("Scrptable Object")]
    public CardSO CS;

    // Start is called before the first frame update
    void Start()
    {
        Name.text = CS.cardName;
        Description.text = CS.cardDescription;
        Card.sprite = CS.cardBorder;
        Icon.sprite = CS.cardIcon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(CardSO cardso)
    {

    }
}
