using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "nouvel objet", menuName = "Objet" )]
public class Objet : ScriptableObject
{
    public string objName;
    public string description;

    public Sprite model3d;

    public int range;
    public int pointsPeur;
    public int slow;

    public bool champVision;
    public bool meuble;
    public bool lumière;
    public bool sonore;

    public int MaxPeur = 100;
    public int StartPeur = 0;
    public int CurrentPeur;
    public Jauge_Peur PeurBar; 



    void Start()
    {
        CurrentPeur = StartPeur;
        PeurBar.SetMaxPeur(MaxPeur);
    }

    void TakePeur(int Peur)
    {
        CurrentPeur += Peur;
        PeurBar.SetPeur(CurrentPeur);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            TakePeur(20);
        }
    }
}
