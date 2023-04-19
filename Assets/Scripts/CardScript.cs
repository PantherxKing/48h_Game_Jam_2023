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
    public Animator myAni;
    //public Animator horseAnim;
    [Header("Scrptable Object")]
    public CardSO CS;
    HorsemenBase HB;
    Player P;
    public PlayerFeedback feedback;

    // Start is called before the first frame update
    void Start()
    {
        Name.text = CS.cardName;
        Description.text = CS.cardDescription;
        Card.sprite = CS.cardBorder;
        Icon.sprite = CS.cardIcon;
        feedback = feedback.GetComponent<PlayerFeedback>();

    }

    // Update is called once per frame
    void Update()
    {
        HorseMan = GameObject.FindGameObjectWithTag("Enemy");
    }

    public void Attack(CardSO cardso)
    {
        int dmghit = (Random.Range(cardso.damage, cardso.maxDamage));
        myAni = player.GetComponent<Animator>();
        myAni.Play("Attack Hop");
        HB = HorseMan.GetComponent<HorsemenBase>();
        HB.dmg(dmghit);
        feedback.playerFeedback = "You cast the ability: " + Name.text.ToString() + " and attacked for " + dmghit.ToString() + " damage!";
        feedback.charChoices.SetActive(false);
        feedback.nextBut.SetActive(true);
        HB.playerTurnOver = true;
    }

    public void Heal(CardSO cardso)
    {
        HB = HorseMan.GetComponent<HorsemenBase>();
        P = player.GetComponent<Player>();
        P.heal(cardso.heal);
        feedback.playerFeedback = "You cast the ability: " + Name.text.ToString() + " and healed for " + cardso.heal.ToString() + " health!";
        feedback.charChoices.SetActive(false);
        feedback.nextBut.SetActive(true);
        HB.playerTurnOver = true;
    }

    public void Doge()
    {
        HB = HorseMan.GetComponent<HorsemenBase>();
        HB.playerDodge = true;
        HB.playerTurnOver = true;
    }
}
