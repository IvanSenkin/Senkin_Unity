using UnityEngine.UI;
using UnityEngine;

namespace Maze
{
    public class DisplayBonuses : MonoBehaviour
    {
        private Text _text;
        public int _score;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }        
        public void Display(int value)
        {
            Debug.Log(_score);
            _score += value;
            _text.text = $"Good bonus! {value}, Score {_score}";
        }         
    }
}
