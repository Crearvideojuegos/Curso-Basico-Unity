using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NamePong
{
    public class Palas : MonoBehaviour
    {
        [SerializeField] private bool _palaUna;
        [SerializeField] private bool _palaDos;
        private int _direccionPala;
        private Rigidbody2D _rigidbody2d;

        private void Awake() 
        {
            _rigidbody2d = GetComponent<Rigidbody2D>();
        }

        private void Update() 
        {
            if(_palaUna)
            {
                if(Input.GetKey(KeyCode.W))
                {
                    _direccionPala = 1;
                } else if(Input.GetKey(KeyCode.S)) {
                    _direccionPala = -1;
                } else {
                    _direccionPala = 0;
                }
            }

            if(_palaDos)
            {
                if(Input.GetKey(KeyCode.UpArrow))
                {
                    _direccionPala = 1;
                } else if(Input.GetKey(KeyCode.DownArrow)) {
                    _direccionPala = -1;
                } else {
                    _direccionPala = 0;
                }
            }
        }

        private void FixedUpdate() 
        {
            Vector3 paddlePosition = new Vector3 (transform.position.x, transform.position.y, 0);
            _rigidbody2d.velocity = new Vector2(0, _direccionPala) * 10f;
            paddlePosition.y = Mathf.Clamp (paddlePosition.y, -5f, 5f);
            transform.position = paddlePosition;
        }

    }

}
