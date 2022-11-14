using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class S_NavMesh_De_A_a_B : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent navMeshAgent; //Vinculado por Inspector

    [SerializeField]
    Transform t_destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = t_destination.position;
    }
}
