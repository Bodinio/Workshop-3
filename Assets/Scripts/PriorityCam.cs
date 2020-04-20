using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PriorityCam : MonoBehaviour

{
    public CinemachineVirtualCamera originalCamera;
    public CinemachineVirtualCamera destCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            destCamera.Priority = 20;
        }
    }

   /* void phase2()
    {
        if (Input.GetButtonDown("Jump"))  //lancement de la phase d'action
        {
            destCamera.Priority = 20;
        }

    }*/

}
