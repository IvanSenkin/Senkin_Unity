using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze 
{
    public abstract class Bonus : MonoBehaviour, IInteractible
    {
<<<<<<< HEAD
        public int _damage;
        public int value;
        public bool IsInteractible { get; } = true;
        protected Color _color;
       
          
=======
        public int _damage ;
        public bool IsInteractible { get; } = true;
        protected Color _color;
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
        private void Start()
        {
            Action();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractible||!other.CompareTag("Player"))
            {
                return;
            }
            Interaction(_damage);
<<<<<<< HEAD
            other.GetComponent<Player>().TakeDamage(_damage);
            Destroy(gameObject);

           
=======
            Destroy(gameObject);
            other.GetComponent<Player>().TakeDamage(_damage);
            
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
        }
        protected abstract void Interaction(int _damage);
        public void Action()
        {
            _color = Random.ColorHSV();

           if(TryGetComponent(out Renderer renderer))
            {
                renderer.sharedMaterial.color = _color;
            }
        }
    }
}
