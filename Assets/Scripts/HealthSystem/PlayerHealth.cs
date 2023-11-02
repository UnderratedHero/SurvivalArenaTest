using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    [SerializeField] private PlayerConfig _config;

    public event Action<float> OnDecrease;

    private void Awake()
    {
        Current = _config.MaxHealthPoints;
    }

    public float Current { get; private set; }

    public void Decrease(float value)
    {
        Current -= value;

        if(Current <= _config.MinHealthPoints)
        {
            Current = _config.MinHealthPoints;
        }

        OnDecrease?.Invoke(_config.MinHealthPoints);
    }

    public void Increase(float value)
    {
        Current += value;

        if(Current >=_config.MaxHealthPoints)
        {
            Current = _config.MaxHealthPoints;
        }
    }
}
