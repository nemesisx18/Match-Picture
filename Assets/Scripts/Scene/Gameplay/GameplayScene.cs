using MatchPicture.Global;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MatchPicture.Scene.Gameplay
{
    public class GameplayScene : MonoBehaviour, IButtonable
    {
        [SerializeField] private Button _backButton;

        void Start()
        {
            SetAllButtonListener();
        }

        private void SetBackButtonListener(UnityAction listener)
        {
            SetButtonListener(_backButton, listener);
        }

        public void SetAllButtonListener()
        {
            SetBackButtonListener(OnClickBackButton);
        }

        public void SetButtonListener(Button button, UnityAction listener)
        {
            button.onClick.AddListener(listener);
        }

        public void OnClickBackButton()
        {
            SceneManager.LoadScene("Home");
        }
    }
}