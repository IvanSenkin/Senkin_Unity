using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2

namespace Maze
{
    public sealed class Player : Unit
    {
<<<<<<< HEAD
        private int _hp;
        private int _damage;
        [SerializeField] private int _maxHP;
        public float Speed;
        private void Awake()
        {
            _hp = _maxHP;
        }
        private void Start()
        {
            Speed = 1;
=======
        public static Action<int> changeHP;
        private int _hp;
        private int _damage;
        [SerializeField] private int _maxHP;
        private void Awake()
        {
            _hp = _maxHP;          
        }
        private void Start()
        {
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
            _transform = GetComponent<Transform>();
            if (GetComponent<Rigidbody>())
            {
                _rigidbody = GetComponent<Rigidbody>();
            }
        }
        private void Update()
        {
<<<<<<< HEAD
            Move(Speed);
        }
        public static Action<int> changeHP;
=======
            Move();
        }
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
        public void TakeDamage(int damage)
        {
           // damage = UnityEngine.Random.Range(0, 1);
            _hp -= damage;
            changeHP?.Invoke(_hp);
            Debug.Log("Damage");
            if (_hp <= 0)
            {
                Debug.Log("Dead");
<<<<<<< HEAD
                Invoke("LoseCanvas", 1f);
            }
        }
        private void LoseCanvas()
        {
            CanvasController.Instance.gameObject.SetActive(true);
            Time.timeScale = 0;
          //  Application.LoadLevel("SampleScene");
        }
=======
            }
        }
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
    }
}
