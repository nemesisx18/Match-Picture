using MatchPicture.Global.Data;
using System.Collections.Generic;
using UnityEngine;

namespace MatchPicture.Scene.Gameplay.Tile
{
    public class TileGroup : MonoBehaviour
    {
        [SerializeField] private TileObject _tile;
        [SerializeField] private List<TileObject> _tiles = new List<TileObject>();
        private int _row = 6;
        private int _column = 5;
        private int _space = 1;
        private Sprite[] _sprites;
        private Vector3 _startPos;

        public List<Sprite> spawnIndex = new List<Sprite>();

        private void Start()
        {
            _startPos = new Vector3(-2, -3, 0);
            SetSprites();
            RandomizeTile();
            SpawnTile();
        }

        public void SetSprites()
        {
            ThemeDatabase _themeData = ThemeDatabase.themeInstance;
            _sprites = _themeData.ThemeDatas[SaveData.saveInstance.CurrentTheme].Sprites;
        }

        public void RandomizeTile()
        {
            int indexLoop = _row * _column;

            for (int i = 0; i < indexLoop / 2; i++)
            {
                //loop array sprite
                if (i <= _sprites.Length)
                {
                    spawnIndex.Add(_sprites[i]);
                    spawnIndex.Add(_sprites[i]);

                }
                else
                {
                    spawnIndex.Add(_sprites[_sprites.Length - i]);
                    spawnIndex.Add(_sprites[_sprites.Length - i]);
                }

            }
        }

        public void SpawnTile()
        {
            for (int i = 0; i < _column; i++)
            {
                for (int j = 0; j < _row; j++)
                {
                    Vector3 spawnPosition = new Vector3(i * _space, j * _space, 0) + _startPos;
                    TileObject tile = Instantiate(_tile, spawnPosition, Quaternion.identity, transform);

                    int index = Random.Range(0, spawnIndex.Count);
                    tile.ChangeSprite(spawnIndex[index]);
                    //tile.gameObject.SetActive(false);
                    spawnIndex.RemoveAt(index);
                    _tiles.Add(tile);
                }
            }

            //RandomTile();
        }

        public void RandomTile()
        {
            for (int i = 0; i < _tiles.Count; i++)
            {
                //int random = Random.Range(0, spawnIndex.Count);
                _tiles[i].ChangeSprite(spawnIndex[i]);
                //spawnIndex.Remove(_sprites[i]);
                _tiles[i].gameObject.SetActive(true);
            }
        }
    }
}