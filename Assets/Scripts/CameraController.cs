using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Maze
{
    public class CameraController : MonoBehaviour
    {
        private Player _player;
        private Vector3 _offset;
        private Transform camTransform;
        void Start()
        {
           _player = FindObjectOfType<Player>();
           _offset = transform.position - _player.transform.position;
            camTransform = transform;
        }


        void Update()
        {
           camTransform.position = _player.transform.position + _offset;
            PlayerLook();
        }
        protected void PlayerLook()
        {         
            if (Input.GetKey(KeyCode.Space))
            {           
                camTransform.localRotation = Quaternion.Euler(90f, 0f, 0f);
            }   
            else
            {
                transform.localRotation = Quaternion.Euler(60f, 0f, 0f);
            }
        }
    }
}
