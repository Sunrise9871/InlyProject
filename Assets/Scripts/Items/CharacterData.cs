using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "Item", menuName = "Character")]
    public class CharacterData : Data
    {
        [field: SerializeField] public int Level { get; private set; }
        [field: SerializeField] public Transform Model { get; private set; }
    }
}