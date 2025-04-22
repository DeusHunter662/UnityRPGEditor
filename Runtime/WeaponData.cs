using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRPGEditor.Editor
{
    [CreateAssetMenu(menuName = "RPG Editor/New Weapon")]
    public class WeaponData : ItemData
    {
        [field: SerializeField]
        public int Damage { get; private set; } = 5;

        [field: SerializeField]
        public DamageType DamageType { get; private set; }

        [field: SerializeField]
        public float AttackSpeed { get; private set; } = 1f;

        [field: SerializeField]
        public float Range { get; private set; } = 1.5f;

        [field: SerializeField]
        public int Duribility { get; private set; } = 100;
    }

    public enum DamageType
    {
        Physical,
        Fire,
        Cold,
        Lightning,
        Necrotic,
        Void,
        True
    }
}
