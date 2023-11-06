using UnityEngine;

public class PlayerDeathEffect : MonoBehaviour
{
    [SerializeField] private PlayerHealth _health;

    public bool IsDead { get; private set; }

    private void OnEnable()
    {
        _health.OnDecrease += DeadCheck;
    }

    private void OnDisable()
    {
        _health.OnDecrease -= DeadCheck;
    }

    private void DeadCheck(float value)
    {
        if (_health.Current <= value)
        {
            IsDead = true;
        }
    }
}
