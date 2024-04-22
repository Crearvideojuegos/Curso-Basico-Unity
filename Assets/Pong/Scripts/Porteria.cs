using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NamePong
{
    public class Porteria : MonoBehaviour
    {
        [SerializeField] private bool _porteriaIzquierda;
        [SerializeField] private bool _porteriaDerecha;

        void OnTriggerEnter2D (Collider2D other) 
        {
            if(_porteriaIzquierda)
            {
		        Juego.Instance.PorteriaIzquierda();
                other.GetComponent<Pelota>().SpawnPelota(true);

            } else if(_porteriaDerecha)
            {
		        Juego.Instance.PorteriaDerecha();
                other.GetComponent<Pelota>().SpawnPelota(false);
            }

            AudioJuego.Instance.ReproducirSonidoGol();

        }
    }

}
