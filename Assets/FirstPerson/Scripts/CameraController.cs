using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nameFP
{
    public class CameraController : MonoBehaviour
    {
        //Camera Point del del objeto Player
        public Transform Target;

        void LateUpdate()
        {
            //La camera se situara donde este el camera point
            transform.position = Target.position;
            transform.rotation = Target.rotation;
        }
    }

}
