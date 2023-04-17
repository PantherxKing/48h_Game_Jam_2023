using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dmg(int dmg)
    {
        Health -= dmg;
    }

    public void heal(int Heal)
    {
        Health += Heal;
        if (Health >= 50)
        {
            Health = 50;
        }
    }
}
