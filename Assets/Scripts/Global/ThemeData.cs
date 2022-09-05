using UnityEngine;

namespace MatchPicture.Global.Data
{
    [CreateAssetMenu]
    public class ThemeData : ScriptableObject
    {
        [SerializeField] private int _price;
        [SerializeField] private Sprite[] _sprites;

        public int Price => _price;
        public Sprite[] Sprites => _sprites;
    }
}