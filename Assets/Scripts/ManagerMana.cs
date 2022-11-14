using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerMana : MonoBehaviour
{

    [SerializeField]
    Image mana;

    [SerializeField]
    float mana_actual;

    [SerializeField]
    float mana_maxima;


    //CUIDADO DE NO MODIFICAR EN EL INSPECTOR:

    [SerializeField]
    float tiempo_perdida = 2; //tiempo que define cada cuanto perdera mana

    [SerializeField]
    float tiempo_transcurrido = 0;

    /*
    porcentaje de llenado:

        mana maxima  =  1 (fill_amount lleno)  
        mana actual  =  ?

        porcentaje_llenado = mana actual / mana maxima

    */

    // Start is called before the first frame update
    void Start()
    {
        mana_actual = 100;
        mana_maxima = 100;

        tiempo_transcurrido = 0;
    }
    // Update is called once per frame
    void Update()
    {
        tiempo_transcurrido += Time.deltaTime;

        if (mana_actual >= 0 && tiempo_transcurrido>=tiempo_perdida)
        {
            mana.fillAmount = mana_actual / mana_maxima;
            mana_actual--;
            tiempo_transcurrido = 0;
        }
    }
}
