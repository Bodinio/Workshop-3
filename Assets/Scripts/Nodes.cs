using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{
    public Color HoverColor;
    public Color RedColor;
    private Color startColor;
    private Renderer rend;

    private GameObject turret;

    private Gamemanager gamemanager;
    public Vector3 positionOffset;



    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        gamemanager = Gamemanager.s_Singleton;
    }


    private void OnMouseDown()
    {
        if (gamemanager.GetTurretToBuild() == null)
        {
            return;
        }


        GameObject turretToBuild = gamemanager.GetTurretToBuild();
        if (gamemanager.itemSelected == gamemanager.ItemSpherePrefab)
        {
            return;
        }
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    private void OnMouseEnter()
    {
        
        if (gamemanager.itemSelected == null)
        {
            rend.material.color = RedColor;
            return;
        }
        rend.material.color = HoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}