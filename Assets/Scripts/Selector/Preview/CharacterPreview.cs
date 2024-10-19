using Items;
using UnityEngine;
using UnityEngine.UI;

namespace Selector.Preview
{
    public class CharacterPreview : Preview
    {
        [SerializeField] private Image _image;

        private CharacterData _characterData;
        
        public override void Initialize(Data data)
        {
            _characterData = data as CharacterData;
            _image.sprite = _characterData?.Sprite;
        }
    }
}