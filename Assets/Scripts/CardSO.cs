using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Card_", menuName = "ScriptableObjects/Card")]
public class CardSO : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public int damage;
    public Sprite cardBorder;
    public Sprite cardIcon;
}
