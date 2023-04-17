using System;
using UnityEngine;

public class HorsemenBase : MonoBehaviour
{
    // Attack chooser
    // Inherit from Player (Player is actually health script)

    public bool playerTurnOver = false;
    public bool playeerDodge = false;
    private System.Random rd = new System.Random();
    [SerializeField]
    public String HorsemanHeavy;
    [SerializeField]
    public String HorsemanNormal;
    [SerializeField]
    public String HorsemanWeak;
    [SerializeField]
    public String HorsemanMiss;

    private void Start()
    {
        
    }
    private int HitChance() 
    {
        int _attackHitChance = rd.Next(0, 100);
        if (playeerDodge)
        {
            _attackHitChance = 0;
        }
        return _attackHitChance;
    }

    public String AttackType()
    {
        int hitChance = HitChance();
        String _attackType = "";

        if (hitChance >= 85)
        {
            _attackType = "HEAVY";
        }
        else if (hitChance >= 50 && hitChance < 85)
        {
            _attackType = "NORMAL";
        }
        else if (hitChance < 50 && hitChance >= 25)
        {
            _attackType = "WEAK";
        }
        else { _attackType = "MISS"; }

        return _attackType;
    }

    public void Attack() 
    {
        String attack = AttackType();
        if (attack.Equals("MISS"))
        {
            return;
        }
        else if (attack.Equals("HEAVY"))
        {
            // DMG = 15 - 20% player health (nums decided on how big health bar will be)
        }
        else if (attack.Equals("NORMAL"))
        {
            // DMG = 8 - 15% player health (nums decided on how big health bar will be)
        }
        else if (attack.Equals("WEAK")) 
        {
            // DMG = 3 - 8% player health (nums decided on how big health bar will be)
        }
    }

    private void Update()
    {
        if (playerTurnOver) 
        {
            Attack();
        }
    }

}
