using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{
   public Slider Slider;

    public void SetMaxHealth(int health) {
        Slider.maxValue = health;
        Slider.value = health;
    }
   public void SetHealth(int health)
   {
       Slider.value = health;
   }
}
