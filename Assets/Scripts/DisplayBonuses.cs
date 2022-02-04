using UnityEngine.UI;
using UnityEngine;
using System;

namespace Maze
{
    public class DisplayBonuses : MonoBehaviour
    {
        [SerializeField] public Text _text;
        public Image _hpBar;
        public float _fill;
        private void Awake()
        {
            Player.changeHP += UpdateHP;
        }
        private void Start()
        {
            _fill = 1f;          
        }
        public DisplayBonuses()
        {
           _text = FindObjectOfType<Text>();
            
        }
        public void Display(int value)
        {         
            _text.text = $"Good bonus! {value}";
        }
        private void UpdateHP(int hp)
        {
            _hpBar.fillAmount = hp * 0.01f;
            _text.text = (hp * 0.01f).ToString();
        }
    }
}
