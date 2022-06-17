using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class L8_1 : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _navMeshAgent.SetDestination(target.position);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _navMeshAgent.isStopped = !_navMeshAgent.isStopped;
        }
    }
}
