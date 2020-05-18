using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private Gamemanager GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = Gamemanager.s_Singleton;
    }

    public void PurchaseMeuble01()
    {
        GameManager.SetTurretToBuild(GameManager.Meuble01);
        Debug.Log("Meuble 01 Séléctionné");
    }

    public void PurchaseMeuble02()
    {
        GameManager.SetTurretToBuild(GameManager.Meuble02);
        Debug.Log("Meuble 02 Séléctionné");
    }

    public void PurchaseMeuble03()
    {
        GameManager.SetTurretToBuild(GameManager.Meuble03);
    }

    public void PurchaseLumineux01()
    {
        GameManager.SetTurretToBuild(GameManager.Lumineux01);
    }

    public void PurchaseLumineux02()
    {
        GameManager.SetTurretToBuild(GameManager.Lumineux02);
    }

    public void PurchaseSonore01()
    {
        GameManager.SetTurretToBuild(GameManager.Sonore01);
    }

    public void PurchaseSonore02()
    {
        GameManager.SetTurretToBuild(GameManager.Sonore02);
    }
}
