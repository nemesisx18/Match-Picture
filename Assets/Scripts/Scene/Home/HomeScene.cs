using MatchPicture.Global;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MatchPicture.Scene.Home
{
    public class HomeScene : MonoBehaviour, IButtonable
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _themeButton;

        private void Start()
        {
            SetAllButtonListener();
        }

        private void SetPlayButtonListener(UnityAction listener)
        {
            SetButtonListener(_playButton, listener);
        }
        private void SetThemeButtonListener(UnityAction listener)
        {
            SetButtonListener(_themeButton, listener);
        }

        public void SetAllButtonListener()
        {
            SetPlayButtonListener(OpenGameplay);
            SetThemeButtonListener(OpenTheme);
        }

        public void SetButtonListener(Button button, UnityAction listener)
        {
            button.onClick.AddListener(listener);
        }

        private void OpenGameplay()
        {
            SceneManager.LoadScene("Gameplay");
        }

        private void OpenTheme()
        {
            SceneManager.LoadScene("Theme");
        }
    }
}