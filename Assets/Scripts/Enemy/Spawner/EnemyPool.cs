using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private int _poolSise = 16;
    [SerializeField] private bool _isAutoExpand;
    [SerializeField] private Enemy _prefab;
    private ObjectPool<Enemy> _enemies;

    private void Start()
    {
        _enemies = new ObjectPool<Enemy>(_prefab, _isAutoExpand, transform, _poolSise);
    }
    
    public Enemy CreateEnemie()
    {
        var enemie = _enemies.GetFreeElement();
        return enemie;
    }
}
