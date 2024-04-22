using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NamePong
{
    public class Pelota : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2d;
        private int _velocidadPelota;
        
        private void Awake() 
        {
            _rigidbody2d = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            SpawnPelota(true);
        }

        public void SpawnPelota(bool direccionSalida)
        {
            _velocidadPelota = 10;

            int direccionPelota = direccionSalida == true ? 1 : -1;

            if(!Juego.Instance.JuegoAcabado)
            {
                Vector2 direction;
                float y = Random.Range(-2.0f, 2.0f);
                direction = new Vector2(direccionPelota, y).normalized;
                transform.position = new Vector3 (0f,0f,0f);
                _rigidbody2d.velocity =  direction * _velocidadPelota;
            }
        }

        private void OnCollisionEnter2D(Collision2D other) 
        {
            if(other.gameObject.tag == "Pala")
            {
                _velocidadPelota++;
                AudioJuego.Instance.ReproducirSonidoPala();
            }

            if(other.gameObject.tag == "Muro")
            {
                AudioJuego.Instance.ReproducirSonidoMuro();
            }
        }



    }

}
