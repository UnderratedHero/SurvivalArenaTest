using UnityEngine;

[CreateAssetMenu(fileName = "Range Weapon Config", menuName = "Config/Weapon Config/Range Weapon", order = 51)]

public class RangeWeaponConfig : ScriptableObject
{
    [field: SerializeField] public float WeaponDamage { get; private set; } = 0f;

    [field: SerializeField] public float BulletLifeTime { get; private set; } = 0f;

    [field: SerializeField] public float BulletSpeed { get; private set; } = 0f;

}