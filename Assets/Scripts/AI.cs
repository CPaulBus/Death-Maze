using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public Transform destin;
    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }
    private void Update()
    {
        if (agent.remainingDistance<0.5)
        {
            this.GetComponent<Light>().color = Color.white;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            agent.destination = other.transform.position;
            this.GetComponent<Light>().color = Color.red;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            agent.destination = other.transform.position;
            this.GetComponent<Light>().color = Color.red;
        }
    }
}
