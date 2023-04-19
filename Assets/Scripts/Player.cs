using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public Slider healthSlider;
    public TMP_Text healthNum;

    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
        healthSlider.maxValue = MaxHealth;
        healthSlider.value = MaxHealth;
    }

    // Update is called once per frame
    public void Update()
    {
        healthNum.text = Health.ToString() + "/" + MaxHealth.ToString();
    }

    public void dmg(int dmg)
    {
        Health -= dmg;
        healthSlider.value = Health;
        //Die();
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

    //public void Die()
    //{
    //    string sceneName = "GameOver";

    //    if(Health <= 0)
    //    {
    //        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    //    }
    //}
}
