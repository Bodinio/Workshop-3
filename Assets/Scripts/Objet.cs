using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "nouvel objet", menuName = "Objet" )]
public class Objet : MonoBehaviour
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

    public Gamemanager gamemanager;

    void Start()
    {
        
    }

    void TakePeur(int Peur)
    {
        CurrentPeur += Peur;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            gamemanager.JaugePeur.fillAmount += 0.2f;
        }
    }
}
