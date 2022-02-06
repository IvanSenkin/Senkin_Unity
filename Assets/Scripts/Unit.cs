using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Maze
{
    public abstract class Unit : MonoBehaviour
    {
        public Rigidbody _rigidbody;
        public Transform _transform;
        private Vector3 movement;

        private float horizontal;
        private float vertical;

<<<<<<< HEAD
        //public float Speed;
        protected void Move(float Speed)
=======
        public float Speed = 5;
        protected void Move()
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            movement = new Vector3(horizontal, 0f, vertical);
            if (_rigidbody)
            {
                _rigidbody.AddForce(movement * Speed);
            }
            else
            {
                Debug.Log("NO Rigidbody");
            }
        }
    }
}
