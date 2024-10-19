using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class WindowCloser : MonoBehaviour
    {
        [SerializeField] private RectTransform _window;

        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() => Destroy(_window.gameObject));
        }
    }
}
