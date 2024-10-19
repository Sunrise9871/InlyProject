using System.Collections.Generic;
using Items;
using Player;
using UnityEngine;
using UnityEngine.UI;

namespace Selector.View
{
    public abstract class View : MonoBehaviour
    {
        private readonly List<Preview.Preview> _items = new();
        
        [SerializeField] private List<Data> _characterData;
        [SerializeField] private GridLayoutGroup _gridLayoutGroup;
        [SerializeField] private ScrollRect _scrollRect;
        [SerializeField] private Preview.Preview _viewPreview;

        private PlayerInput _playerInput;
        private Presenter.Presenter _presenter;

        public void Initialize(Presenter.Presenter presenter, PlayerInput playerInput)
        {
            _presenter = presenter;
            _playerInput = playerInput;
            _playerInput.HorizontalMove += OnHorizontalMove;
            _playerInput.VerticalMove += OnVerticalMove;
        } 
        
        private void Start() => Spawn();
        
        private void OnDestroy()
        {
            _playerInput.HorizontalMove -= OnHorizontalMove;
            _playerInput.VerticalMove -= OnVerticalMove;
        }

        public void SelectThumbnail(int id)
        {
            _items[id].Select();
            DisplayInformation(_characterData[id]);
        }
        
        public void DeselectThumbnail(int id) => _items[id].Deselect();
        
        public void MoveScroll(int id)
        {
            var rowsCount = _characterData.Count / _gridLayoutGroup.constraintCount;
            var currentRow = id / _gridLayoutGroup.constraintCount;
            var position = 1f - (float)currentRow / (rowsCount - 1);

            _scrollRect.verticalNormalizedPosition = position;
        }

        private void Spawn()
        {
            for (var i = 0; i < _characterData.Count; i++)
            {
                var item = Instantiate(_viewPreview, _gridLayoutGroup.transform);

                item.Initialize(_characterData[i]);
                var id = i;
                item.Bind(() => OnThumbnailSelected(id));
                _items.Add(item);
            }
        }

        private void OnHorizontalMove(int direction) => 
            _presenter.OnMoveSelection(direction, _characterData.Count);

        private void OnVerticalMove(int direction) =>
            _presenter.OnMoveSelection(direction * _gridLayoutGroup.constraintCount, _characterData.Count);

        private void OnThumbnailSelected(int id) => _presenter.OnThumbnailSelected(id);
        
        protected abstract void DisplayInformation(Data data);
    }
}