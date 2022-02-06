using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Maze
{
    public class GoodBonus : Bonus, IFly, IRotation
    {
       
        float heightFly = 3f;       
        public float speedRotation = 3;
        private DisplayBonuses _displayBonuses;
<<<<<<< HEAD
        [SerializeField] private Material _material;
        private void Awake()
        {
            //_displayBonuses = new DisplayBonuses();
            _damage = -50;
            value = _damage;
        }      
        protected override void Interaction(int _damage)
        {
            //_displayBonuses.Display(_damage);    
=======
        private void Awake()
        {        
            _displayBonuses = new DisplayBonuses();
            _damage = -50;
        }      
        protected override void Interaction(int _damage)
        {
            _displayBonuses.Display(_damage);    
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
        }     

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, heightFly), transform.position.z);
        }      
        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speedRotation), Space.World);
        }
    }
}
