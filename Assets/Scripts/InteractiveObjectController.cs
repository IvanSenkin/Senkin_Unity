using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
<<<<<<< HEAD
    public sealed class InteractiveObjectController : MonoBehaviour
    {
        private Bonus[] _interactiveObject;
        //private int _index = -1;
        //public object Current => _interactiveObject[_index];
        
        //public bool MoveNext()
        //{
        //    if (_index == _interactiveObject.Length -1)
        //    {
        //        Reset();
        //        return false;
        //    }
        //        _index++;
        //    return true;
        //}
        //public void Reset()
        //{
        //    _index = -1;
        //}
        private void Awake()
        {
            _interactiveObject = FindObjectsOfType<Bonus>();          
        }
          
=======
    public class InteractiveObjectController : MonoBehaviour
    {
        private Bonus[] _interactiveObject;

        private void Awake()
        {
            _interactiveObject = FindObjectsOfType<Bonus>();
        }

       
      
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
        void Update()
        {
            for (int i = 0; i < _interactiveObject.Length; i++)
            {
                if(_interactiveObject[i] == null)
                {
                    continue;
                }

                if (_interactiveObject[i]  is IFly fly)
                {
                    fly.Fly();
                }

                if (_interactiveObject[i] is IRotation rotation)
                {
                    rotation.Rotate();
                }

                if (_interactiveObject[i] is IFlicker flick)
                {
                    flick.Flick();
                }

            }
        }
    }
<<<<<<< HEAD
   //public class InteractiveObj : MonoBehaviour
   // {
   //     private void Start()
   //     {
   //         InteractiveObjectController _interactiveObjectController = new InteractiveObjectController();
   //            while (_interactiveObjectController.MoveNext())
   //         {
   //             Debug.Log(_interactiveObjectController.Current);
               
   //         }
   //     }
   // }

=======
>>>>>>> be46c89f4083feb7e2791fbb737358b582c207d2
}
