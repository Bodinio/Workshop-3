using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jauge_Peur : MonoBehaviour
{

    public Slider slider;

    public float MaxPeur;


    
    public void SetPeur(int Peur)
    {
        slider.value = Peur;
    }

    public void SetMaxPeur(int Peur)
    {
        slider.maxValue = MaxPeur;
        slider.value = Peur;
    }

}