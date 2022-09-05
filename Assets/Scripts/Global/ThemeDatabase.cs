using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchPicture.Global.Data
{
    public class ThemeDatabase : MonoBehaviour
    {
        [SerializeField] private List<ThemeData> _themeDatas = new List<ThemeData>();

        public List<ThemeData> ThemeDatas => _themeDatas;

        public static ThemeDatabase themeInstance;

        private void Awake()
        {
            if(themeInstance != null && themeInstance != this)
            {
                Destroy(this);
            }
            else
            {
                themeInstance = this;
                DontDestroyOnLoad(this);
            }
        }
    }
}