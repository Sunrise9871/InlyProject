using Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Selector.View
{
    public class SceneView : View
    {
        [SerializeField] private Image _sceneImage;
        [SerializeField] private TextMeshProUGUI _sceneID;
        [SerializeField] private TextMeshProUGUI _sceneDescription;
        
        protected override void DisplayInformation(Data data)
        {
            var sceneData = data as SceneData;
            
            _sceneImage.sprite = sceneData?.Sprite;
            _sceneID.text = $"id: {sceneData?.ID}";
            _sceneDescription.text = sceneData?.Description;
        }
    }
}