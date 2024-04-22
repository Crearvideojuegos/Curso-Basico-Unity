using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nameFP
{
    public class Moneda : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other) 
        {
            if(other.gameObject.tag == "Player")
            {
                Juego.Instance.ObtenerMoneda();
                Destroy(gameObject);
            }
        }
    }
}
