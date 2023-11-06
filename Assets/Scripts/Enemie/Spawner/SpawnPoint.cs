using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private EnemiePool _enemies;
    [SerializeField] private EnemieConfig _config;

    private void OnEnable()
    {
        _timer.SetTimer(_config.SpawnTime);
        _timer.OnTimeEnd += SpawnEnemie;
    }

    private void OnDisable()
    {
        _timer.OnTimeEnd -= SpawnEnemie;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.layer);
        enabled = false;       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enabled = true;   
        Debug.Log(enabled);
    }

    private void SpawnEnemie()
    {
        _enemies.CreateEnemie();
    }
}
