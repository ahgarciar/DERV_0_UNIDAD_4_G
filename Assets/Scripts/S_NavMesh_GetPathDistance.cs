using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class S_NavMesh_GetPathDistance : MonoBehaviour
{
    [SerializeField]
    Transform origen;

    [SerializeField]
    Transform destino;

    NavMeshPath path; //camino calculado

    [SerializeField]
    float elapsed = 0f;

    [SerializeField]
    bool esValido;

    [SerializeField]
    float distancia_a_destino; //longitud del camino (path)

    [SerializeField]
    float distancia_con_vector3; //distancia euclidiana 
    
    // Start is called before the first frame update
    void Start()
    {
        path = new NavMeshPath();
        elapsed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Update the way to the goal every second.
        elapsed += Time.deltaTime;
        if (elapsed > 1f) {
            elapsed -= 1.0f;
            esValido = NavMesh.CalculatePath(origen.position, destino.position, NavMesh.AllAreas, path);
            Debug.Log(path.status);
            //NavMeshPathStatus.   <--- PathComplete / PathPartial / PathInvalid            
        }

        distancia_a_destino = 0;
        for (int i = 0; i < path.corners.Length-1; i++)
        {
            distancia_a_destino += Vector3.Distance(path.corners[i], path.corners[i + 1]);
            Debug.DrawLine(path.corners[i], path.corners[i + 1], Color.red);
        }

        //Calculo de la distancia euclidiana... para comparacion
        distancia_con_vector3 = Vector3.Distance(origen.position, destino.position);


    }
}
