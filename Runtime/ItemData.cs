using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRPGEditor.Editor
{
   
    public abstract class ItemData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField]
        public string Description { get; private set; }

        [field: SerializeField, PreviewField(Height = 50)]
        public Sprite Icon { get; private set; }

        [field: SerializeField, SuffixLabel("Gold", true)]
        public string Value { get; private set; }

        [field: SerializeField, SuffixLabel("kg", true)]
        public string Weight { get; private set; }

        [field: SerializeField]
        public ItemRarity Rarity { get; private set; } = ItemRarity.Common;
    }
    public enum ItemRarity
    {
        Common,
        Uncommon,
        Rare,
        Magic,
        Epic,
        Legendary,
        Mythic
    }
}
