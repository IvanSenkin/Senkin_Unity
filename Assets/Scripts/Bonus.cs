using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze 
{
    public abstract class Bonus : MonoBehaviour, IInteractible
    {
        public int _damage;
        public int value;
        public bool IsInteractible { get; } = true;
        protected Color _color;
       
          
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
            other.GetComponent<Player>().TakeDamage(_damage);
            Destroy(gameObject);

           
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