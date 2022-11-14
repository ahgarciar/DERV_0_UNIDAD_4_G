using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class S_NavMeshExtras : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent navMeshAgent;

    [SerializeField]
    float remainingDistance;

    [SerializeField]
    float stoppingDistance;

    [SerializeField]
    bool pathPending; //falta camino por ser procesado

    [SerializeField]
    bool hasPath; //falta camino por ser recorrido

    ///////////////CHECK LLEGO AL DESTINO
    [SerializeField]
    bool check_en_destino_1;

    [SerializeField]
    bool check_en_destino_2;

    [SerializeField]
    bool check_en_destino_3;
    [SerializeField]
    Transform origen;
    [SerializeField]
    Transform destino;

    // Start is called before the first frame update
    void Start()
    {
        //navMeshAgent.stoppingDistance = 0; //recomendacion para evitar algunos errores
        navMeshAgent.isStopped = true;
        //navMeshAgent.SetPath //... //Si se desea cambiar el path por algun otro que haya sido procesado
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) { navMeshAgent.isStopped = false; }
        if (Input.GetKeyDown(KeyCode.T)) { navMeshAgent.isStopped = true; }

        remainingDistance = navMeshAgent.remainingDistance;
        stoppingDistance = navMeshAgent.stoppingDistance;
        pathPending = navMeshAgent.pathPending;
        hasPath= navMeshAgent.hasPath;

        /////
        check_en_destino_1 = remainingDistance <= stoppingDistance;

        check_en_destino_2 = remainingDistance <= stoppingDistance && !pathPending;

        check_en_destino_3 = Vector3.Distance(origen.position, destino.position) <= stoppingDistance;
        ////
    }
}
