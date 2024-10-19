using Items;
using TMPro;
using UnityEngine;

namespace Selector.View
{
    public class CharacterView : View
    {
        [SerializeField] private Transform _visualModel;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _level;
        
        protected override void DisplayInformation(Data data)
        {
            var characterData = data as CharacterData;
            
            var position = _visualModel.position;
            var parent = _visualModel.parent;
            Destroy(_visualModel.gameObject);

            _visualModel = Instantiate(characterData?.Model, position, Quaternion.identity, parent);
            _name.text = characterData?.Name;
            _level.text = $"{characterData?.Level} lvl";
        }
    }
}