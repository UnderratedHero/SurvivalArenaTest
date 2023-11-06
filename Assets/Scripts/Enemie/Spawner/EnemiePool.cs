using UnityEngine;

public class EnemiePool : MonoBehaviour
{
    [SerializeField] private int _poolSise = 16;
    [SerializeField] private bool _isAutoExpand;
    [SerializeField] private Enemie _prefab;
    private ObjectPool<Enemie> _enemies;

    private void Start()
    {
        _enemies = new ObjectPool<Enemie>(_prefab, _isAutoExpand, transform, _poolSise);
    }
    
    public Enemie CreateEnemie()
    {
        var enemie = _enemies.GetFreeElement();
        return enemie;
    }
}
