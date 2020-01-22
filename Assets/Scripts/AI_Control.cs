using System.Collections;
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
    }*/

        // Start is called before the first frame update
        void Start()
    {
        m_NavMeshAgent.SetDestination(m_Target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    private void OnTriggerEnter(Collider other)
    {
        m_NavMeshAgent.SetDestination(m_Target2.transform.position);
        
    }
 
}
