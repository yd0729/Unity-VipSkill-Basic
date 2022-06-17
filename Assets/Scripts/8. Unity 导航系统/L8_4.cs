using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class L8_4 : MonoBehaviour
{
    private Animator _animator;
    private NavMeshAgent _navMeshAgent;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                _navMeshAgent.SetDestination(hit.point);
                Debug.DrawLine(ray.origin, hit.point, Color.red, 2f);
                _animator.SetBool("Run", true);
            }
        }

        if (Vector3.Distance(transform.position, _navMeshAgent.destination) < _navMeshAgent.stoppingDistance)
        {
            _animator.SetBool("Run", false);
        }
    }
}
