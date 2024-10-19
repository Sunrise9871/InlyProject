using Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Selector.Preview
{
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(Button))]
    public abstract class Preview : MonoBehaviour
    {
        private Image _background;
        private Button _button;
        
        public abstract void Initialize(Data data);
        
        private void Awake()
        {
            _background = GetComponent<Image>();
            _button = GetComponent<Button>();
        }
        
        public void Bind(UnityAction action) => _button.onClick.AddListener(action);

        public void Select() => _background.enabled = true;

        public void Deselect() => _background.enabled = false;
    }
}