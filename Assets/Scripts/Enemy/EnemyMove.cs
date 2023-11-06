using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private PlayerSearch _playerSearch;
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private EnemyConfig _config;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
       _rigidBody.velocity = _playerSearch.MoveDirection * _config.MoveSpeed;
    }
}
