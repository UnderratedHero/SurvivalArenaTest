using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Config", menuName = "Config/Weapon Config", order = 51)] 

public class WeaponConfig : ScriptableObject
{
    [field: SerializeField] public float WeaponDamage { get; private set; } = 0f;

    [field: SerializeField] public float AttackCoolDown { get; private set; } = 0f;

    [field: SerializeField] public float AttackSpeed { get; private set; } = 0f;
}
