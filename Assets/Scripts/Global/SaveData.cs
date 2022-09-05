using UnityEngine;

namespace MatchPicture.Global.Data
{
    public class SaveData : MonoBehaviour
    {
        public static SaveData saveInstance;

        private const string _prefsKey = "ThemeData";
        public int gold = 100;
        [SerializeField] private int _currentTheme = 0;
        [SerializeField] private int _boughtTheme = 2;

        public int BoughtTheme => _boughtTheme;
        public int CurrentTheme => _currentTheme;

        private void Awake()
        {
            if (saveInstance != null && saveInstance != this)
            {
                Destroy(this);
            }
            else
            {
                saveInstance = this;
                DontDestroyOnLoad(this);
            }

            Load();
        }

        public void UpdateGold(int amount)
        {
            gold = amount;
            Save();
        }

        public void UpdateTheme(int themeIndex)
        {
            _currentTheme = themeIndex;
            Save();
        }

        public void BuyTheme(int index)
        {
            _boughtTheme = index;
            Save();
        }

        private void Save()
        {
            string json = JsonUtility.ToJson(this);
            PlayerPrefs.SetString(_prefsKey, json);
            Debug.Log(json);
        }

        private void Load()
        {
            if(PlayerPrefs.HasKey(_prefsKey))
            {
                string json = PlayerPrefs.GetString(_prefsKey);
                JsonUtility.FromJsonOverwrite(json, this);
            }
            else
            {
                Save();
            }
        }
    }
}
