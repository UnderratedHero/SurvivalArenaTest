using UnityEngine;

[CreateAssetMenu(fileName ="Enemy Config", menuName = "Config/Enemy Config", order = 51)]

public class EnemyConfig : ScriptableObject
{
    [field: SerializeField] public float MaxHealthPoints { get; private set; } = 0f;

    [field: SerializeField] public float MinHealthPoints { get; private set; } = 0f;
    
    [field: SerializeField] public float SpawnTime { get; private set; } = 0f;

    [field: SerializeField] public float MoveSpeed { get; private set; } = 0f;

    [field: SerializeField] public float Damage { get; private set; } = 0f;
}
