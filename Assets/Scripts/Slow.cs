using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Slow : MonoBehaviour
{
    public float timeSlow;
    public Transform target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private IEnumerator SlowTarget()
    {
        agent.speed = 0.25f;
        yield return new WaitForSeconds(timeSlow);
        agent.speed = 0.75f;
    }
}