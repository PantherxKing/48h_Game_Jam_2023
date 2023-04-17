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
    public GameObject HorseMan;
    public GameObject player;
    [Header("Scrptable Object")]
    public CardSO CS;
    HorsemenBase HB;
    Player P;

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
        HorseMan = GameObject.FindGameObjectWithTag("Enemy");
    }

    public void Attack(CardSO cardso)
    {
        
        HB = HorseMan.GetComponent<HorsemenBase>();
        HB.dmg(cardso.damage);
        HB.playerTurnOver = true;
    }

    public void Heal(CardSO cardso)
    {
        P = player.GetComponent<Player>();
        P.heal(cardso.heal);
        HB.playerTurnOver = true;
    }
}
