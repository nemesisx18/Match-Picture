using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchPicture.Scene.Gameplay.Tile
{
    public class TileGroup : MonoBehaviour
    {
        [SerializeField] private Sprite[] _sprites;
        
        public void SetSprites(Sprite[] sprites)
        {
            _sprites = sprites;
        }
    }
}