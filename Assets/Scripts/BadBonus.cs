using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Maze
{
    public sealed class BadBonus : Bonus, IFly, IFlicker
    {
        private float heightFly;
        private DisplayBonuses _displayBonuses;


        [SerializeField] private Material _material;
        private void Awake()
        {
            _displayBonuses = new DisplayBonuses();
            heightFly = Random.Range(1f, 5f);
            _damage = 60;
        }
        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, heightFly), transform.position.z);
        }

        public void Flick()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }
        protected override void Interaction(int _damage)
        {
            Debug.Log("No iteraction");
            _displayBonuses.Display(_damage);
        }

      
    }
}
