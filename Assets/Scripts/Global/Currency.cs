using UnityEngine;

namespace MatchPicture.Global.Data
{
    public class Currency : MonoBehaviour
    {
        public static Currency currencyInstance;

        [SerializeField] private int _gold;
        private SaveData _saveData;

        private void Awake()
        {
            if(currencyInstance != null && currencyInstance != this)
            {
                Destroy(this);
            }
            else
            {
                currencyInstance = this;
                DontDestroyOnLoad(this);
            }
        }

        private void Start()
        {
            _saveData = SaveData.saveInstance;
            SetGold();
        }

        private void SetGold()
        {
            _gold = _saveData.gold;
        }

        public void AddGold(int amount)
        {
            _gold += amount;
            _saveData.UpdateGold(_gold);
        }

        public void SpendGold(int gold)
        {
            _gold -= gold;
            _saveData.UpdateGold(_gold);
        }
    }
}
