using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace nameFP
{
    public class Juego : MonoBehaviour
    {
        [SerializeField] private GameObject _panelVictoria;
        [SerializeField] private TMP_Text _tiempoTexto;
        [SerializeField] private TMP_Text _monedasTexto;
        [SerializeField] private TMP_Text _victoriaTexto;

        private int _monedas;
        private float _tiempoRestante;
        public bool JuegoAcabado;
        public static Juego Instance;

        private void Awake() 
        {
            Instance = this;
            _monedas = 0;
            _tiempoRestante = 30f;
            _panelVictoria.SetActive(false);
            JuegoAcabado = false;
        }

        private void Update() 
        {
            ComprobarJuego();
            if(!JuegoAcabado)
            {
                _tiempoRestante -= Time.deltaTime;
                _tiempoTexto.text = "Time: " + _tiempoRestante.ToString("f2") + " seconds";
            }

        }

        private void ComprobarJuego()
        {
            if(_monedas >= 5)
            {
                _victoriaTexto.text = "Has ganado";

            }

            if(_tiempoRestante <= 0f)
            {
                _victoriaTexto.text = "Has perdido";
            }

            if(_monedas >= 5 || _tiempoRestante <= 0f)
            {
                JuegoAcabado = true;
                _panelVictoria.SetActive(true);
                _tiempoTexto.text = "Time: 0 seconds";
            }
        }

        public void ObtenerMoneda()
        {
            _monedas++;
            _monedasTexto.text = _monedas.ToString();
        }

        public void ReiniciarJuego()
        {
            SceneManager.LoadScene("FirstPerson");
        }

        public void QuitGame()
        {
            Application.Quit();

            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }

    }
}