using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Maze
{
    public sealed class Player : Unit
    {
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
            _transform = GetComponent<Transform>();
            if (GetComponent<Rigidbody>())
            {
                _rigidbody = GetComponent<Rigidbody>();
            }
        }
        private void Update()
        {
            Move(Speed);
        }
        public static Action<int> changeHP;
        public void TakeDamage(int damage)
        {
           // damage = UnityEngine.Random.Range(0, 1);
            _hp -= damage;
            changeHP?.Invoke(_hp);
            Debug.Log("Damage");
            if (_hp <= 0)
            {
                Debug.Log("Dead");
                Invoke("LoseCanvas", 1f);
            }
        }
        private void LoseCanvas()
        {
            CanvasController.Instance.gameObject.SetActive(true);
            Time.timeScale = 0;
          //  Application.LoadLevel("SampleScene");
        }
    }
}
