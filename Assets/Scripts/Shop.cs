using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    private Gamemanager GameManager;

    public GameObject BoutonM1;
    public GameObject BoutonM2;
    public GameObject BoutonM3;
    public GameObject BoutonL1;
    public GameObject BoutonL2;
    public GameObject BoutonS1;
    public GameObject BoutonS2;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = Gamemanager.s_Singleton;
    }

    public void PurchaseMeuble01()
    {
        GameManager.SetTurretToBuild(GameManager.Meuble01);
        Debug.Log("Meuble 01 Séléctionné");
        GameManager.Bouton = BoutonM1.GetComponent<Button>();
    }

    public void PurchaseMeuble02()
    {
        GameManager.SetTurretToBuild(GameManager.Meuble02);
        Debug.Log("Meuble 02 Séléctionné");
        GameManager.Bouton = BoutonM2.GetComponent<Button>();
    }

    public void PurchaseMeuble03()
    {
        GameManager.SetTurretToBuild(GameManager.Meuble03);
        GameManager.Bouton = BoutonM3.GetComponent<Button>();
    }

    public void PurchaseLumineux01()
    {
        GameManager.SetTurretToBuild(GameManager.Lumineux01);
        GameManager.Bouton = BoutonL1.GetComponent<Button>();
    }

    public void PurchaseLumineux02()
    {
        GameManager.SetTurretToBuild(GameManager.Lumineux02);
        GameManager.Bouton = BoutonL2.GetComponent<Button>();
    }

    public void PurchaseSonore01()
    {
        GameManager.SetTurretToBuild(GameManager.Sonore01);
        GameManager.Bouton = BoutonS1.GetComponent<Button>();
    }

    public void PurchaseSonore02()
    {
        GameManager.SetTurretToBuild(GameManager.Sonore02);
        GameManager.Bouton = BoutonS2.GetComponent<Button>();
    }
}
