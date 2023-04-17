using EZCameraShake;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HorsemenBase : Player
{
    // Attack chooser
    // Inherit from Player (Player is actually health script)
    [Header("Controls")]
    public bool playerTurnOver = false;
    public bool playerDodge = false;
    private System.Random rd = new System.Random();
    [Header("GameObjects")]
    [SerializeField]
    Player Target;
    [SerializeField]
    PlayerFeedback feedback;
    [SerializeField]
    Transform parent;
    [Header("Strings")]
    public String horsemenName;
    public String HorsemanHeavy;
    public String HorsemanNormal;
    public String HorsemanWeak;
    public String HorsemanMiss;
    [Header("Shake Shake")]
    public float Magnitude;
    public float Roughness;
    public float FadeIn;
    public float FadeOut;

    private void Start()
    {
        Target = GameObject.Find("Player").GetComponent<Player>();
        feedback = GameObject.Find("Scripts").GetComponent<PlayerFeedback>();
        transform.SetParent(GameObject.Find("GameFight").transform);
    }
    private int HitChance()
    {
        int _attackHitChance = rd.Next(0, 100);
        CameraShaker.Instance.ShakeOnce(Magnitude, Roughness, FadeIn, FadeOut);
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
        int dmg = 0;

        if (attack.Equals("MISS")) 
        {
            feedback.WriteToScreen(horsemenName + HorsemanMiss);
            return;
        }
        else if (attack.Equals("HEAVY"))
        {
            dmg = rd.Next(15, 20); // DMG = 15 - 20% player health (nums decided on how big health bar will be)
            feedback.WriteToScreen(horsemenName + " " + HorsemanHeavy + " for " + dmg.ToString() + " damage!");
        }
        else if (attack.Equals("NORMAL"))
        {
            dmg = rd.Next(8, 15); // DMG = 8 - 15% player health (nums decided on how big health bar will be)
            feedback.WriteToScreen(horsemenName + " " + HorsemanNormal + " for " + dmg.ToString() + " damage!");
        }
        else if (attack.Equals("WEAK"))
        {
            dmg = rd.Next(3, 8); // DMG = 3 - 8% player health (nums decided on how big health bar will be)
            feedback.WriteToScreen(horsemenName + " " + HorsemanWeak + " for " + dmg.ToString() + " damage!");
        }
        Target.dmg(dmg);
        StartCoroutine(feedback.FlashRed(Target.gameObject.GetComponent<Image>()));     
    }

    private void Update()
    {
        if (playerTurnOver)
        {
            Attack();
        }
        if (feedback.flashOver) 
        {
            StopCoroutine(feedback.FlashRed(Target.gameObject.GetComponent<Image>()));
        }
        playerTurnOver = false;

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
