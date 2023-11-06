using UnityEngine;

[CreateAssetMenu(fileName ="Enemie Config", menuName = "Config/Enemie Config", order = 51)]

public class EnemieConfig : ScriptableObject
{
    [field: SerializeField] public float SpawnTime { get; private set; } = 0f;
}
