using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MatchPicture.Scene.Gameplay.Timer
{
    public class GameTimer : MonoBehaviour
    {
        [SerializeField] private float _time = 300;
        [SerializeField] private bool timerIsRunning = false;
        [SerializeField] private TextMeshProUGUI timeText;

        private void Start()
        {
            // Starts the timer automatically
            timerIsRunning = true;
        }

        private void Update()
        {
            RunTimer();
        }

        public void RunTimer()
        {
            if (timerIsRunning)
            {
                timeText.text = _time.ToString();
                if (_time > 0)
                {
                    _time -= Time.deltaTime;
                }
                else
                {
                    Debug.Log("Time has run out!");
                    _time = 0;
                    timerIsRunning = false;
                }
            }
        }
    }
}