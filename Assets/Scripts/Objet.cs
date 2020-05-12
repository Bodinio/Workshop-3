using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "nouvel objet", menuName = "Objet" )]
public class Objet : ScriptableObject
{
    public string objName;
    public string description;

    public Sprite model3d;

    public int range;
    public int pointsFear;
    public int slow;

    public bool champVision;
    public bool meuble;
    public bool lumière;
    public bool sonore;


}
