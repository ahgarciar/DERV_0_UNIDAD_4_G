using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_BarraVida : MonoBehaviour
{
    [SerializeField]
    Image barraVida; //vinculada por inspector

    [SerializeField]
    float vida_actual; //definida en START

    [SerializeField]
    int vida_maxima = 100;

    // Start is called before the first frame update
    void Start()
    {
        vida_actual = 100;
        //StartCoroutine(gestionVida());
        StartCoroutine("gestionVida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator gestionVida() {
        for (int i = vida_maxima; i > 0 ; i--)
        {
            vida_actual--;
            barraVida.fillAmount = vida_actual / vida_maxima;
            //yield return null;
            yield return new WaitForSeconds(0.1f);

            //100     1
            // X
        }
    }

}
