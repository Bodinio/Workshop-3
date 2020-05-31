using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodesFenetres : MonoBehaviour
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

    private bool NodeAlreadyTaken;


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
        if (NodeAlreadyTaken == true)
        {
            return;
        }


        GameObject turretToBuild = gamemanager.GetTurretToBuild();
        if (gamemanager.itemSelected == gamemanager.Meuble01 && gamemanager.m1 == false)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetBureau, transform.rotation);
            NodeAlreadyTaken = true;

            gamemanager.Bouton.interactable = false;
            gamemanager.m1 = true;

        }
        if (gamemanager.itemSelected == gamemanager.Meuble02 && gamemanager.m2 == false)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetChaise, transform.rotation);
            NodeAlreadyTaken = true;
            gamemanager.Bouton.interactable = false;
            gamemanager.m2 = true;
        }
        if (gamemanager.itemSelected == gamemanager.Meuble03 && gamemanager.m3 == false)
            if (gamemanager.itemSelected == gamemanager.Meuble03)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetVolets, transform.rotation);
            NodeAlreadyTaken = true;
            gamemanager.Bouton.interactable = false;
                gamemanager.m3 = true;
            }
       if (gamemanager.itemSelected == gamemanager.Lumineux01 && gamemanager.l1 == false)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetBougie, transform.rotation);
            NodeAlreadyTaken = true;
            gamemanager.Bouton.interactable = false;
            gamemanager.l1 = true;
        }
        if (gamemanager.itemSelected == gamemanager.Lumineux02 && gamemanager.l2 == false)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetFoudre, transform.rotation);
            NodeAlreadyTaken = true;
            gamemanager.Bouton.interactable = false;
            gamemanager.l2 = true;
        }
        if (gamemanager.itemSelected == gamemanager.Sonore01 && gamemanager.s1 == false)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetGuitare, transform.rotation);
            NodeAlreadyTaken = true;
            gamemanager.Bouton.interactable = false;
            gamemanager.s1 = true;
        }
        if (gamemanager.itemSelected == gamemanager.Sonore02 && gamemanager.s2 == false)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffsetTVMeuble, transform.rotation);
            NodeAlreadyTaken = true;
            gamemanager.Bouton.interactable = false;
            gamemanager.s2 = true;
        }

    }

    private void OnMouseEnter()
    {

        if (gamemanager.itemSelected == null || gamemanager.itemSelected == gamemanager.Meuble03 && gamemanager.m3 == true || gamemanager.itemSelected == gamemanager.Lumineux02 && gamemanager.l2 == true || gamemanager.itemSelected == gamemanager.Sonore02 && gamemanager.s2 == true || gamemanager.itemSelected == gamemanager.Meuble01 && gamemanager.m1 == true || gamemanager.itemSelected == gamemanager.Meuble02 && gamemanager.m2 == true || gamemanager.itemSelected == gamemanager.Meuble03 && gamemanager.m3 == true || gamemanager.itemSelected == gamemanager.Sonore01 && gamemanager.s1 == true || gamemanager.itemSelected == gamemanager.Lumineux01 && gamemanager.l1 == true)
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