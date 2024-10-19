using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "Item", menuName = "Scene")]
    public class SceneData : Data
    {
        [field: SerializeField] public int ID { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
    }
}