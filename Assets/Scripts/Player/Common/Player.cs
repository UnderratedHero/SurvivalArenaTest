using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerHealth _health;
    [SerializeField] private int _enemyLayerID;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer != _enemyLayerID)
        {
            return;
        }

        collision.gameObject.TryGetComponent<Enemy>(out var enemy);
        _health.Decrease(enemy.Config.Damage);
    }
}
