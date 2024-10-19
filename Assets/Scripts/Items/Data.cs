using UnityEngine;

namespace Items
{
    public abstract class Data : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite Sprite { get; private set; }
    }
}