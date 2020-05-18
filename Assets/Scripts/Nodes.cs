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
    public Vector3 positionOffsetBureau;
    public Vector3 positionOffsetChaise;
    public Vector3 positionOffsetVolets;
    public Vector3 positionOffsetBougie;
    public Vector3 positionOffsetFoudre;
    public Vector3 positionOffsetGuitare;
    public Vector3 positionOffsetTVMeuble;


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
        if (gamemanager.itemSelected == gamemanager.Meuble01)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetBureau, transform.rotation);
        }
        if (gamemanager.itemSelected == gamemanager.Meuble02)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetChaise, transform.rotation);
        }
        if (gamemanager.itemSelected == gamemanager.Meuble03)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetVolets, transform.rotation);
        }
        if (gamemanager.itemSelected == gamemanager.Lumineux01)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetBougie, transform.rotation);
        }
        if (gamemanager.itemSelected == gamemanager.Lumineux02)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetFoudre, transform.rotation);
        }
        if (gamemanager.itemSelected == gamemanager.Sonore01)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetGuitare, transform.rotation);
        }
        if (gamemanager.itemSelected == gamemanager.Sonore02)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetTVMeuble, transform.rotation);
        }

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