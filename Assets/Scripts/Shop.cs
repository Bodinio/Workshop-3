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

    public void purchaseStadartTurret()
    {
        GameManager.SetTurretToBuild(GameManager.standardTurretPrefab);
    }

    public void purchaseItemSphere()
    {
        GameManager.SetTurretToBuild(GameManager.ItemSpherePrefab);
    }

}
