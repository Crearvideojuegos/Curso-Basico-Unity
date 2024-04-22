using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NameBasicos
{

    enum DiasDeLaSemana
    {
        Lunes, 
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    enum EstadosPuzzle
    {
        Desactivado = 0,
        Activado = 1,
        Iniciado = 2
    }

    public class Basicos : MonoBehaviour
    {
        private int _numeroClase;

        public const float NUMEROPI = 3.1419f;
        public const string MINOMBRE = "Alex";

        void Start()
        {
            // OperacionesAritmeticas();
            // int numeroSumado = SumaDosNumeros(2, 2);
            // Debug.Log("El numero sumado es: " + numeroSumado);
            // TeoriaIfElse();
            // TeoriaOperadores();
            // NumeroParOImpar(3);
            // TeoriaOperadorTernario();
            // TeoriaSwitch();
            // TeoriaWhile();
            // TeoriaFor();
            // TeoriaArrays();
            // TeoriaListas();
            // TeoriaForEach();
            // _numeroClase = 3;
            // TeoriaAlcanceDos();
            // TeoriaAlcanceUno();
            // TeoriaEnum();
        }


        void TeoriaEnum()
        {
            Debug.Log("Hoy es " + DiasDeLaSemana.Martes);

            int estadoActualPuzzle = (int)EstadosPuzzle.Activado;

            Debug.Log("El estado actual del Puzzle es " + estadoActualPuzzle);

        }


        void TeoriaAlcanceUno()
        {
            _numeroClase = 5;
        }

        void TeoriaAlcanceDos()
        {
            Debug.Log(_numeroClase);
        }

        void TeoriaForEach()
        {
            bool[] verdadONo = { true, false, false, true, false };

            foreach(bool verdad in verdadONo)
            {
                Debug.Log(verdad);
            }

            List<string> nombresMascotas = new List<string> { "Anvorgueso" , "Milanesa" , "Gato" };


            foreach(string nombreMascota in nombresMascotas)
            {
                Debug.Log(nombreMascota);
            }


        }

        void TeoriaListas()
        {
            List<string> nombresTipicos = new List<string>();
            nombresTipicos.Add("Antonio");

            List<string> nombresMascotas = new List<string> { "Anvorgueso" , "Milanesa" , "Gato" };

            int numeroTres = 3;


            for(int i = 0; i < nombresMascotas.Count; i++)
            {
                Debug.Log(nombresMascotas[i]);
            }

        }


        void TeoriaArrays()
        {
            int[] miPrimerArray;
            // string[] arrayDePalabras;
            // float [] arrayDeDecimales;
            // bool[] arrayDeVerdades;

            miPrimerArray = new int[5];

            miPrimerArray[0] = 23;
            miPrimerArray[1] = 7;
            miPrimerArray[2] = 56;
            miPrimerArray[3] = 128;
            miPrimerArray[4] = 75;

            int[] segundoArray = { 14, 5, 39, 4, 99 };

            Array.Sort(segundoArray);

            for(int i = 0; i < segundoArray.Length; i++)
            {
                Debug.Log("Numero en el array: " + segundoArray[i]);
            }

        }
        
        void TeoriaFor()
        {
            for(int i = 1; i <= 10; i++)
            {
                Debug.Log(i);
            }

            int[] numeroAr = { 3, 5 , 7};

            int[] numeros = { 5, 2, 4, 1, 3 };

            // Ordenar los números en orden ascendente
            // Array.Sort(numeros);


        }


        void TeoriaWhile()
        {
            int contador = 1;

            while(contador <= 10)
            {
                Debug.Log(contador);
                contador++;
            }

            contador = 1;

            do
            {
                Debug.Log(contador);
                contador++;
            } while(contador <= 10);

        }

        void TeoriaSwitch()
        {
            int numeroTres = 3;

            switch(numeroTres)
            {
                case 1:
                    Debug.Log("Es el numero 1");
                    break;
                case 2:
                    Debug.Log("Es el numero 2");
                    break;
                case 3:
                    Debug.Log("Es el numero 3");
                    break;
                case 4:
                    Debug.Log("Es el numero 4");
                    break;
                case 5:
                    Debug.Log("Es el numero 5");
                    break;
                default:
                    Debug.Log("No es un numero entre el 1 y el 5");
                    break;
            }

            int dia = 6;
            switch(dia)
            {
                case 1:
                    Debug.Log("Lunes");
                    break;
                case 2:
                    Debug.Log("Martes");
                    break;
                case 3:
                    Debug.Log("Miércoles");
                    break;
                case 4:
                    Debug.Log("Jueves");
                    break;
                case 5:
                    Debug.Log("Viernes");
                    break;
                case 6:
                    Debug.Log("Sábado");
                    break;
                case 7:
                    Debug.Log("Domingo");
                    break;
            }
        }

        void TeoriaOperadorTernario()
        {
            int numeroCinco = 5;
            bool esPar = numeroCinco % 2 == 0 ? true : false;
            Debug.Log("Es par" + esPar);

            int numeroCeroFalso = 0;
            bool esFalso = numeroCeroFalso == 0 ? false : true;
        }


        void NumeroParOImpar(int numero)
        {
            if(numero % 2 == 0)
            {
                Debug.Log("El numero es par");
            } else {
                Debug.Log("El numero es impar");
            }
        }


        void TeoriaOperadores()
        {
            bool tenerLlave = false;

            if(!tenerLlave)
            {
                Debug.Log("No tenemos la llave");
            }

            int numeroUno = 1;
            int numeroDos = 2;

            if(numeroUno == 1)
            {
                Debug.Log("El numero es igual");
            }

            //No es necesario igualar a false, podriamos negarlo ! y funcionaria igual
            //Ej if(!tenerLlave == false)
            if(tenerLlave == false)
            {
                Debug.Log("No tenemos la llave");
            }

            if(numeroUno != 4)
            {
                Debug.Log("El numero no es igual");
            }

            if(numeroUno == 1 && numeroDos == 2)
            {
                Debug.Log("Ambos numeros son igual a la variable");
            }

            if(numeroUno == 3 || numeroDos == 2)
            {
                Debug.Log("Una de las dos condiciones se cumple");
            }

            if(numeroDos > numeroUno)
            {
                Debug.Log("Dos es mayor que uno");
            }

            if(numeroUno < numeroDos)
            {
                Debug.Log("Uno es menor que dos");
            }

            if(numeroUno <= 1)
            {
                Debug.Log("El valor de la variable es igual o menor que uno");
            }

            if(numeroUno >= 2)
            {
                Debug.Log("El valor de la variable es igual o mayor que dos");
            }

        }

        void TeoriaIfElse()
        {
            bool tenerLLave = false;

            if(tenerLLave)
            {
                Debug.Log("Tenemos la llave");
            } 

            int numeroNuevo = 4;

            if(numeroNuevo == 1)
            {
                Debug.Log("Es el número 2");
            } else if (numeroNuevo == 2)
            {
                Debug.Log("Es el número 2");
            } else if (numeroNuevo == 3)
            {
                Debug.Log("Es el número 3");
            } else if (numeroNuevo == 4)
            {
                Debug.Log("Es el número 4");
            } else {
                Debug.Log("No es ninguno de estos números");
            }
        }

        int SumaDosNumeros(int numeroUno, int numeroDos, int numeroTres = 0)
        {
            return numeroUno + numeroDos;
        }

        void OperacionesAritmeticas()
        {
            int numeroUno = 3;
            int numeroDos = 5;

            int sumaResultado, restaResultado, multiplicacionResultado, divisionResultado, moduloResultado;

            //Suma
            sumaResultado = numeroUno + numeroDos;
            sumaResultado += numeroUno;
            
            //Resta
            restaResultado = numeroDos - numeroUno;
            restaResultado -= numeroUno;

            //Multiplicación
            multiplicacionResultado = numeroUno * numeroDos;
            multiplicacionResultado *= numeroUno;

            //División
            divisionResultado = numeroDos / numeroUno;
            divisionResultado /= numeroDos;

            //Módulo
            moduloResultado = numeroDos % numeroUno;
            moduloResultado %= numeroDos;

            //Numeros Directamente
            int otraSuma = 3 + 5;

            otraSuma++;
            otraSuma--;

            Debug.Log("Soy la función Operaciones Aritméticas");
        }
    }

}
