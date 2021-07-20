using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarFilling;
    public float maxHealth = 0.3f;
    public float health;

    //public Image XpBarFilling; // 2 paseks
    //public float minXp = 1f;
    //public float Xp;


    void Start()
    {
        healthBarFilling = this.GetComponent<Image>();
        //XpBarFilling = GetComponent<Image>();
        health = maxHealth;
        //Xp = minXp;
    }

    public void AddXp(float value)
    {
        //XpBarFilling.fillAmount += value;
    }

    public void AddHealth(float value)
    {
        healthBarFilling.fillAmount += value;
    }

    public void MinusHealth(float value)
    {
        healthBarFilling.fillAmount -= value;
    }

    public void UpdateHealth()
    {
        healthBarFilling.fillAmount = health / maxHealth;
    }
}
