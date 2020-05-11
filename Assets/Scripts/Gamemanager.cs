using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class Gamemanager : MonoBehaviour
{
    private float distanceToCamera;
    private float YOrig;

    public CinemachineVirtualCamera originalCamera;
    public CinemachineVirtualCamera destCamera;

    [SerializeField] public NavMeshAgent m_NavMeshAgent;
    [SerializeField] public GameObject m_Target;
    [SerializeField] public GameObject m_Target2;
    public bool enter = true;
    public bool exit = true;
    public int Phase2 = 0;

    public GameObject standardTurretPrefab;
    public GameObject ItemSpherePrefab;

    private GameObject turretToBuild;
    public GameObject itemSelected;


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
        }
        if (Input.GetButtonDown("Jump") && Phase2 == 0)  //lancement de la phase d'action
        {
            StartPhase2();
            Phase2++;
        }
        itemSelected = turretToBuild;
    }

    void phase2()
    {
            destCamera.Priority = 20;
        Phase2 += 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        m_NavMeshAgent.SetDestination(m_Target2.transform.position); //change de target après avoir récupéré l'objectif 
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
