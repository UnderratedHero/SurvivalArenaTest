using UnityEngine;

public class BulletErase : MonoBehaviour
{
    [SerializeField] private RangeWeaponConfig _config;

    private void Start()
    {
        Destroy(gameObject, _config.BulletLifeTime);
    }
}
