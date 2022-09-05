using UnityEngine.Events;
using UnityEngine.UI;

namespace MatchPicture.Global
{
    public interface IButtonable
    {
        void SetButtonListener(Button button, UnityAction listener);
        void SetAllButtonListener();
    }
}