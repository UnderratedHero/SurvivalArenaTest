using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private EnemyPool _enemies;
    [SerializeField] private EnemyConfig _config;
    [SerializeField] private int _layerNumber;

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

    private void SpawnEnemy()
    {
        _enemies.CreateEnemie();
    }
}
