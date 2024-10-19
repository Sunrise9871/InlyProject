using Player;
using Selector.Model;
using Selector.Presenter;
using Selector.View;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Button))]
    public class WindowOpener : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private View _view;
        
        private Button _button;
        
        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OpenWindow);
        }

        private void OpenWindow()
        {
            var view = Instantiate(_view, transform.root);
            var model = new SingleSelectModel(view);
            var presenter = new GridPresenter(model);
            
            view.Initialize(presenter, _playerInput);
        }
    }
}