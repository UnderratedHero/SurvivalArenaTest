using System;
using UnityEngine;

public class EnemieScanner : MonoBehaviour
{
    [SerializeField] private Vector2 _scanArea;
    [SerializeField] private int _maxScanEnemies;
    [SerializeField] private LayerMask _enemieLayer;

    private Collider2D[] _enemies;

    private void Start()
    {
        _enemies = new Collider2D[_maxScanEnemies];
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector2.zero, _scanArea);
    }

    public bool TryGetEnemie()
    {
        Scan();
        if(_enemies == null)
        {
            return false;
        }
        return true;
    }

    private void Scan()
    {
        Array.Clear(_enemies, 0, _maxScanEnemies);
        Physics2D.OverlapBoxNonAlloc(transform.position, _scanArea, transform.rotation.z, _enemies, _enemieLayer);
    }
}
