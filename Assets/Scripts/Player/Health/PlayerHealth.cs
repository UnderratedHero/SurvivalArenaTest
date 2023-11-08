using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    [SerializeField] private PlayerConfig _config;

    public event Action OnDecrease;

    private void Awake()
    {
        Current = _config.MaxHealthPoints;
    }

    public bool IsDead { get; private set; }

    public float Current { get; private set; }

    public void Decrease(float value)
    {
        Current -= value;

        if(Current <= _config.MinHealthPoints)
        {
            Current = _config.MinHealthPoints;
            IsDead = true; 
        }
        OnDecrease?.Invoke();
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
