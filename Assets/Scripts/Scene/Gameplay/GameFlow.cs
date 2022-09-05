using MatchPicture.Global.Data;
using MatchPicture.Scene.Gameplay.Tile;
using MatchPicture.Scene.Gameplay.Timer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchPicture.Scene.Gameplay
{
    public class GameFlow : MonoBehaviour
    {
        [SerializeField] private TileGroup _tiles;

        private SaveData _saveData;
        private GameTimer _timer;

        private void Start()
        {
            _saveData = SaveData.saveInstance;
        }
    }
}