using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchPicture.Scene.Gameplay.Tile
{

    public class TileObject : MonoBehaviour
    {
        private Sprite _sprite;
        [SerializeField] private SpriteRenderer _renderer;
        
        public void ChangeSprite(Sprite sprite)
        {
            _sprite = sprite;
            _renderer.sprite = _sprite;
        }
    }
}