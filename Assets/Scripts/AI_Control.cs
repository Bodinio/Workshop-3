/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AI_Control : MonoBehaviour
{

    [SerializeField] private NavMeshAgent m_NavMeshAgent;
    [SerializeField] private GameObject m_Target;
    [SerializeField] private GameObject m_Target2;
    public bool enter = true;
    public bool exit = true;
    public int Phase2 = 0;

    public static AI_Control s_Singleton;

    //public int m_Priority = 10;

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

    /* void OnGUI()
     {
         Event e = Event.current;
         if (e.button == 0 && e.isMouse)
         {
             Debug.Log("Left Click");
         }
         else if (e.button == 1)
         {
             Debug.Log("Right Click");
         }
         else if (e.button == 2)
         {
             Debug.Log("Middle Click");
         }
     }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Phase2 == 0)  //lancement de la phase d'action
        {
            StartPhase2();
            Phase2++;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        m_NavMeshAgent.SetDestination(m_Target2.transform.position); //change de target après avoir récupéré l'objectif 
    }
    private void StartPhase2()
    {
        m_NavMeshAgent.SetDestination(m_Target.transform.position); // va vers l'objectif
    }
    
   
}*/
