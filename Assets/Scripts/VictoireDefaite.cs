using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoireDefaite : MonoBehaviour
{

    private Gamemanager gamemanager;

    public GameObject CanvasWin;

    public GameObject CanvasLoose;

    private void Start()
    {
        gamemanager = Gamemanager.s_Singleton;
    }


    void Update()
    {
        if (gamemanager.JaugePeur.fillAmount == 1f)
        {
            CanvasWin.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Defaite"))
        {
            Debug.Log("Sauce");
            CanvasLoose.SetActive(true);
        }
    }
}
