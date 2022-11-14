using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class S_NavMesh_ClickMouse : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent navMeshAgent; //Vinculado por Inspector


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Click Izquierdo
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)){
                navMeshAgent.destination = hit.point;
            }
        }

    }
}
