using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_MovObstaculos : MonoBehaviour
{
    [SerializeField]
    Transform[] puntos;

    [SerializeField]
    int indexPunto;

    [SerializeField]
    float velocidad; //asignada en inspector

    // Start is called before the first frame update
    void Start()
    {
        indexPunto = 0; //Primer Ubicacion
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, puntos[indexPunto].position)<0.1f) {
            indexPunto = ++indexPunto % puntos.Length;            
        }
        transform.position = Vector3.MoveTowards(transform.position, puntos[indexPunto].position, velocidad * Time.deltaTime);

    }
}
