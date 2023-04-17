using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
        healthSlider.maxValue = MaxHealth;
        healthSlider.value = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dmg(int dmg)
    {
        Health -= dmg;
        healthSlider.value = Health;
    }

    public void heal(int Heal)
    {
        Health += Heal;

        if (Health >= MaxHealth)
        {
            Health = MaxHealth;
        }

        healthSlider.value = Health;
    }
}