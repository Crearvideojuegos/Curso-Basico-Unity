using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NamePong
{
    public class Juego : MonoBehaviour
    {
        [SerializeField] private GameObject _panelVictoria;
        [SerializeField] private TMP_Text _marcadorIzquierdo;
        [SerializeField] private TMP_Text _marcadorDerecho;
        [SerializeField] private TMP_Text _victoriaTexto;

        private int _marcadorJugadorUno;
        private int _marcadorJugadorDos;
        public bool JuegoAcabado;
        public static Juego Instance;

        private void Awake() 
        {
            Instance = this;
            _marcadorJugadorUno = 0;
            _marcadorJugadorDos = 0;
            _panelVictoria.SetActive(false);
            JuegoAcabado = false;
        }


        public void PorteriaIzquierda()
        {
            _marcadorJugadorDos++;
            _marcadorDerecho.text = _marcadorJugadorDos.ToString();
            ComprobarJuego();
        }

        public void PorteriaDerecha()
        {
            _marcadorJugadorUno++;
            _marcadorIzquierdo.text = _marcadorJugadorUno.ToString();
            ComprobarJuego();
        }

        private void ComprobarJuego()
        {
            if(_marcadorJugadorUno >= 5)
            {
                _panelVictoria.SetActive(true);
                JuegoAcabado = true;
                _victoriaTexto.text = "El jugador uno ha ganado";
                AudioJuego.Instance.ReproducirSonidoVictoria();
            }

            if(_marcadorJugadorDos >= 5)
            {
                _panelVictoria.SetActive(true);
                JuegoAcabado = true;
                _victoriaTexto.text = "El jugador dos ha ganado";
                AudioJuego.Instance.ReproducirSonidoVictoria();
            }
        }

        public void ReiniciarJuego()
        {
            SceneManager.LoadScene("Pong");
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