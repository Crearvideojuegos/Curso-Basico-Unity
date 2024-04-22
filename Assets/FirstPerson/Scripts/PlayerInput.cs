using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace nameFP
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerController _playerController; //Input System
        private CharacterController _characterController;
        private float _xRotation;

        public static PlayerInput Instance;
        public Transform CamPointTrans;
        public Vector2 MoveInput; //WASD Movement
        public Vector3 MoveData;
        public Vector2 LookInput; //Mouse Look Movement
        public float mouseSensitivityX;
        public float mouseSensitivityY;

        private void Awake() 
        {
            Instance = this;
            _playerController = new PlayerController();
            _characterController = GetComponent<CharacterController>();
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Start()
        {
            _playerController.Enable();
        }

        private void Update()
        {
            if(!Juego.Instance.JuegoAcabado)
            {
                CaptureInput();
            } else if (Juego.Instance.JuegoAcabado) {
                Cursor.lockState = CursorLockMode.None;
            }
        }

        private void FixedUpdate() 
        {
            if(!Juego.Instance.JuegoAcabado)
            {
                MoveCharacter();
                Look();
            }
        }

        private void CaptureInput()
        {
            MoveInput = _playerController.PlayerInAc.Move.ReadValue<Vector2>();
            LookInput = _playerController.PlayerInAc.Look.ReadValue<Vector2>();
        }

        private void MoveCharacter()
        {
            Vector3 vertMove = transform.forward * MoveInput.y; // Z
            Vector3 horiMove = transform.right * MoveInput.x; // X
            MoveData = horiMove + vertMove;
            MoveData.Normalize();
            MoveData = MoveData * 5f;

            MoveData.y += Physics.gravity.y * 10f * Time.fixedDeltaTime;

            _characterController.Move(MoveData * Time.fixedDeltaTime);
        }


        private void Look()
        {
            Vector2 mouseInput = new Vector2(LookInput.x * mouseSensitivityX, LookInput.y * mouseSensitivityY);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);
            _xRotation -= mouseInput.y;
            _xRotation = Mathf.Clamp(_xRotation, -65f, 65f);
            CamPointTrans.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        }


    }
}

