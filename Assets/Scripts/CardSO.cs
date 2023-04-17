using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Card_", menuName = "ScriptableObjects/Card")]
public class CardSO : ScriptableObject
{
    [Header("Caard info")]
    public string cardName;
    public string cardDescription;
    public Sprite cardBorder;
    public Sprite cardIcon;
    [Header("values")]
    public int damage;
    public int heal;
}
