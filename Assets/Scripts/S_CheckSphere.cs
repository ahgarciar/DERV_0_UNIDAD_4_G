using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CheckSphere : MonoBehaviour
{
    [SerializeField]
    bool entra_campo_enemigo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CheckSphere CheckCapsule CheckBox
        entra_campo_enemigo = Physics.CheckSphere(transform.position, 3f); //Soporta LayerMask Si fuera necesario
        //                                        posicion          radio
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, 3f);
    }

}
