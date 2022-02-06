using UnityEngine.UI;
using UnityEngine;


namespace Maze
{
    public class Display : MonoBehaviour
    {
        public Text _text;
        public Image _hpBar;
        public float _fill;
        public int value;
        private void Start()
        {
          //  DisplayBonuses displayBonuses = new DisplayBonuses();
           // displayBonuses.Display(value);
            _fill = 1f;
        }
        private void Awake()
        {
            Player.changeHP += UpdateHP;
        }
        private void UpdateHP(int hp)
        {
            _hpBar.fillAmount = hp * 0.01f;
            _text.text = (hp * 0.01f).ToString();
        }
    }
    public class DisplayBonuses 
    {      
        //[SerializeField] public Text _text;// можно ли сериализовыввать поля в классах не отнаследованных от монобеха?
        //public DisplayBonuses()
        //{
        //    _text = Object.FindObjectOfType<Text>();
        //}
        //public void Display(int value)
        //{         
        //    _text.text = $"Good bonus! {value}";
        //}
    }  
}
