using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class SpeedBonus : Bonus
    {
        
        Player _player = new Player();
            
        protected override void Interaction(int _damage)
        {
            _player.Speed = 10;
            //_displayBonuses.Display(_damage);    
        }
    }
}
