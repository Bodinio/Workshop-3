using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Fear : MonoBehaviour
{
    public float timeFear;
    public Transform target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private IEnumerator FearTarget()
    {
        agent.speed = 0.15f;
        yield return new WaitForSeconds(timeFear);
        agent.speed = 0.75f;
    }
}
