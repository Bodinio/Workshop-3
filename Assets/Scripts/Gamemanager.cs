using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    private float distanceToCamera;
    private float YOrig;

    public CinemachineVirtualCamera originalCamera;
    public CinemachineVirtualCamera destCamera;

    [SerializeField] public NavMeshAgent m_NavMeshAgent;
    [SerializeField] public GameObject m_Target;
    [SerializeField] public GameObject m_Target3;
    [SerializeField] public GameObject m_TargetToStop;
    public bool enter = true;
    public bool exit = true;
    public bool Phase2 = false;

    public GameObject Meuble01;
    public GameObject Meuble02;
    public GameObject Meuble03;
    public GameObject Lumineux01;
    public GameObject Lumineux02;
    public GameObject Sonore01;
    public GameObject Sonore02;

    private GameObject turretToBuild;
    public GameObject itemSelected;

    public Animator animShop;

    public Image JaugePeur;
    public float PeurProgress = 0f;
    public GameObject Neutre;
    public GameObject Peur;
    public GameObject Inquiet;

    public GameObject Nodes;

    public bool AnimPlaying;

    public static Gamemanager s_Singleton;


    private void Awake()
    {
        if (s_Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            s_Singleton = this;
        }
    }

    private void Start()
    {
        /*distanceToCamera = Camera.main.transform.position.y - transform.position.y;
        YOrig = transform.position.y;*/
        JaugePeur.fillAmount = 0f;
    }

    /*void OnMouseDrag()
    {
        if (Gamemanager.s_Singleton.Phase2 == 0)
        {
            Vector3 temp = Input.mousePosition;
            temp.z = distanceToCamera;
            Vector3 tmpPos = Camera.main.ScreenToWorldPoint(temp);
            tmpPos.y = YOrig;
            transform.position = tmpPos;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))  //lancement de la phase d'action
        {
            Debug.Log("jump effectueé");
            phase2();
            StartPhase2();
        }
        if (Input.GetButtonDown("Jump") && Phase2 == false)  //lancement de la phase d'action
        {
            Phase2 = true;
        }
        itemSelected = turretToBuild;

        if (JaugePeur.fillAmount != PeurProgress)
        {
            JaugePeur.fillAmount += 0.1f;
        }
        if (AnimPlaying == true)
        {
            StopIntru();
        }
    }

    void phase2()
    {
        animShop.SetBool("DisparitionShop", true);
        destCamera.Priority = 20;
        Phase2 = true;
        Nodes.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        m_NavMeshAgent.SetDestination(m_TargetToStop.transform.position); //change de target après avoir récupéré l'objectif 
    }

    private void StopIntru()
    {
        m_NavMeshAgent.SetDestination(m_TargetToStop.transform.position);
    }

    private void StartPhase2()
    {
        m_NavMeshAgent.SetDestination(m_Target.transform.position); // va vers l'objectif
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }


}
