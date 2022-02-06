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
<<<<<<< HEAD
=======


>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
        [SerializeField] private Material _material;
        private void Awake()
        {
            _displayBonuses = new DisplayBonuses();
            heightFly = Random.Range(1f, 5f);
<<<<<<< HEAD
            _damage = 630;
            value = _damage;
=======
            _damage = 60;
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
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
<<<<<<< HEAD
        {           
            //_displayBonuses.Display(_damage);
=======
        {
            Debug.Log("No iteraction");
            _displayBonuses.Display(_damage);
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
        }

      
    }
}
