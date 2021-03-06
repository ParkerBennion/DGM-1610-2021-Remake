using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public Slider sliderBar;
    public Gradient grade;
    public Image fill;

    public void MaxHealth(int health)
    {
        sliderBar.maxValue = health;
        sliderBar.value = health;
        
        fill.color = grade.Evaluate(1f);
    }

    public void MakeHealth(int health)
    {
        sliderBar.value = health;

        fill.color = grade.Evaluate(sliderBar.normalizedValue);
    }
    //^^ changes the ui to match the intager of the max health
    //brackies tutorial helped with this one see status manager for the support script
}
