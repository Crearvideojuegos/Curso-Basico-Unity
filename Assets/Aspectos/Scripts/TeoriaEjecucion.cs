using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeoriaEjecucion : MonoBehaviour
{
    public string NombreObjeto;

    private void Awake() {
        Debug.Log("Soy el Awake");
    }

    private void OnEnable() {
        Debug.Log("Soy el OnEnable");
    }

    void Start()
    {
        Debug.Log("Soy Start");
        // Debug.Log("Este es el objeto " + NombreObjeto);
    }


    void Update()
    {
        Debug.Log("Soy el Update");
    }

    private void FixedUpdate() {
        Debug.Log("Soy el FixedUpdate");
    }

    private void LateUpdate() {
        Debug.Log("Soy el LateUpdate");
    }
}
