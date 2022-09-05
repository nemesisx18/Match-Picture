using MatchPicture.Global;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MatchPicture.Scene.Theme
{
    public class ThemeScene : MonoBehaviour, IButtonable
    {
        [SerializeField] private ThemeList _theme;
        
        [SerializeField] private Button _backButton;
        [SerializeField] private Button[] _themeButtons;
        [SerializeField] private TextMeshProUGUI _goldText;

        private void Start()
        {
            SetAllButtonListener();
        }

        private void Update()
        {
            _goldText.text = _theme.AvaiableGold.ToString() + "G";
        }

        private void SetBackButtonListener(UnityAction listener)
        {
            SetButtonListener(_backButton, listener);
        }

        private void SetThemeButtonListener()
        {
            for (int i = 0; i < _themeButtons.Length; i++)
            {
                int buttonIndex = i;
                _themeButtons[i].onClick.AddListener(() => OnClickThemeButton(buttonIndex));
            }
        }

        public void SetAllButtonListener()
        {
            SetBackButtonListener(OnClickBackButton);
            SetThemeButtonListener();
        }

        public void SetButtonListener(Button button, UnityAction listener)
        {
            button.onClick.AddListener(listener);
        }

        public void OnClickThemeButton(int index)
        {
            _theme.LoadTheme(index);
        }

        private void OnClickBackButton()
        {
            SceneManager.LoadScene("Home");
        }
    }
}