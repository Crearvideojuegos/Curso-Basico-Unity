using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aspectos
{
    public class TeoriaCollider : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("La esfera ha entrado: " + other);
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log("La esfera ha salido: " + other);
        }

    }
}

