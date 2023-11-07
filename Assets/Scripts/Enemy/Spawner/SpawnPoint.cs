using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private EnemyPool _enemies;
    [SerializeField] private EnemyConfig _config;
    [SerializeField] private int _layerNumber;
    private GameObject _currentEnemy;

    private void OnEnable()
    {
        _timer.SetTimer(_config.SpawnTime);
        _timer.OnTimeEnd += SpawnEnemy;
    }

    private void OnDisable()
    {
        _timer.OnTimeEnd -= SpawnEnemy;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer != _layerNumber)
        {
            return;
        }
        enabled = false;       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer != _layerNumber)
        {
            return;
        }
        enabled = true;   
    }

    private void Update()
    {
        if(_currentEnemy == null || !_currentEnemy.TryGetComponent<EnemyHealth>(out var enemyHealth))
        {
            return;
        }
        if(enemyHealth.IsDead)
        {
            _currentEnemy.transform.position = transform.position;
            _currentEnemy.SetActive(false);
            SpawnEnemy();  
        }
    }

    private void SpawnEnemy()
    {
        _currentEnemy = _enemies.CreateEnemie();
    }
}
