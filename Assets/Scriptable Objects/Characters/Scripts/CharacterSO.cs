using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Characters_", menuName = "ScriptableObjects/Characters")]
public class CharacterSO : ScriptableObject
{
    public string Name;
    public int IDNumber;
    public Sprite Portrait;
}
