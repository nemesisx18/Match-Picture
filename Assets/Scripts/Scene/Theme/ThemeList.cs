using MatchPicture.Global.Data;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace MatchPicture.Scene.Theme
{
    public class ThemeList : MonoBehaviour
    {
        [SerializeField] private List<ThemeData> _themeData = new List<ThemeData>();
        [SerializeField] private Sprite[] _sprite;

        private SaveData _saveData;
        private Currency _currency;
        private int _avaiableTheme;
        private int _avaiableGold;

        public int AvaiableGold => _avaiableGold;

        private void Start()
        {
            _saveData = SaveData.saveInstance;
            _currency = Currency.currencyInstance;

            _sprite = _themeData[_saveData.CurrentTheme].Sprites;
            
        }

        private void Update()
        {
            _avaiableTheme = _saveData.BoughtTheme;
            _avaiableGold = _saveData.gold;
        }

        public void LoadTheme(int index)
        {
            if (index + 1 <= _avaiableTheme)
            {
                _sprite = _themeData[index].Sprites;
                _saveData.UpdateTheme(index);
            }
            else
            {
                PurchaseTheme(index);
                
            }
        }

        public void PurchaseTheme(int selectedIndex)
        {
            int price = _themeData[selectedIndex].Price;

            if(_avaiableGold >= price)
            {
                _saveData.BuyTheme(selectedIndex + 1);
                _currency.SpendGold(price);
                _sprite = _themeData[selectedIndex].Sprites;
                _saveData.UpdateTheme(selectedIndex);
            }
            else
            {
                Debug.Log("You don't have enough gold!!");
            }
        }

        public void Infinite()
        {
            _currency.AddGold(100);
        }
    }
}