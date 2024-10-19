using Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Selector.Preview
{
    public class ScenePreview : Preview
    {
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _name;

        private SceneData _sceneData;
        
        public override void Initialize(Data data)
        {
            _sceneData = data as SceneData;
            _image.sprite = _sceneData?.Sprite;
            _name.text = _sceneData?.Name;
        }
    }
}