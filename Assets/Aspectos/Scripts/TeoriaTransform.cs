using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aspectos
{
    public class TeoriaTransform : MonoBehaviour
    {
        public GameObject CuboDos;
        void Start()
        {
            Debug.Log(transform.position);
            transform.position = new Vector3(0, 0, 0);
            CuboDos.transform.position = new Vector3(2, 0, 0);
            StartCoroutine(MoverCubo());
        }

        IEnumerator MoverCubo()
        {
            yield return new WaitForSeconds(1f);
            CuboDos.transform.position = new Vector3(1, 1, 1);

            yield return new WaitForSeconds(1f);
            CuboDos.transform.position = new Vector3(2, 1, 1);

            Debug.Log("Corrutina finalizada");

        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

}
