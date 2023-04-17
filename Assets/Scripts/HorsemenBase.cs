using System;
using UnityEngine;

public class HorsemenBase : Player
{
    // Attack chooser
    // Inherit from Player (Player is actually health script)

    public bool playerTurnOver = false;
    public bool playerDodge = false;
    private System.Random rd = new System.Random();
    [SerializeField]
    Player Target;
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
        Target = Target.GetComponent<Player>();
    }
    private int HitChance()
    {
        int _attackHitChance = rd.Next(0, 100);
        if (playerDodge)
        {
            _attackHitChance -= rd.Next(1, 50);
            if (_attackHitChance < 0)
            {
                _attackHitChance = 0;
            }
        }
        playerDodge = false;
        return _attackHitChance;
    }

    public String AttackType()
    {
        int hitChance = HitChance();
        String _attackType = "";

        if (hitChance >= 80)
        {
            _attackType = "HEAVY";
        }
        else if (hitChance >= 40 && hitChance < 85)
        {
            _attackType = "NORMAL";
        }
        else if (hitChance < 40 && hitChance >= 15)
        {
            _attackType = "WEAK";
        }
        else { _attackType = "MISS"; }

        return _attackType;
    }

    public void Attack()
    {
        String attack = AttackType();

        if (attack.Equals("HEAVY"))
        {
            Target.dmg(rd.Next(15, 20)); // DMG = 15 - 20% player health (nums decided on how big health bar will be)
        }
        else if (attack.Equals("NORMAL"))
        {
            Target.dmg(rd.Next(8, 15)); // DMG = 8 - 15% player health (nums decided on how big health bar will be)
        }
        else if (attack.Equals("WEAK"))
        {
            Target.dmg(rd.Next(3, 8)); // DMG = 3 - 8% player health (nums decided on how big health bar will be)
        }
        Debug.Log(attack);
    }

    private void Update()
    {
        if (playerTurnOver)
        {
            Attack();
        }
        playerTurnOver = false;
        
    }

}
