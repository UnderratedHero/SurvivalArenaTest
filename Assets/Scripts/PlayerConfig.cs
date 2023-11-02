using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Config", menuName ="Config/Player Config",order = 51)]

public class PlayerConfig : ScriptableObject
{
    [field: SerializeField] public float MoveSpeed { get; private set; } = 0f;
}
