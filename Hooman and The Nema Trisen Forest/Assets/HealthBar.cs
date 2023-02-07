using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health, int currentHealth){
        slider.maxValue = health;
        slider.value = currentHealth;
    }

    public void SetHealth(int health){
        slider.value = health;
    }
}
