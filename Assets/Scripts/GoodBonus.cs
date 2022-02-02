using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Maze
{
    public class GoodBonus : Bonus, IFly, IRotation
    {
       
        float heightFly = 3f;
        private float speedRotation;

        private DisplayBonuses _displayBonuses;

        protected override void Interaction(int _damage)
        {
            _displayBonuses.Display(_damage);
        }     
        private void Awake()
        {        
            _displayBonuses = new DisplayBonuses();       
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
