using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
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

}
