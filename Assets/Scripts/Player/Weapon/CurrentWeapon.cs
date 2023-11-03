using System;
using UnityEngine;

public class CurrentWeapon : MonoBehaviour
{
    [SerializeField] private Collider2D _meleeWeaponCollider;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private MeleeWeaponConfig _meleeConfig;
    [SerializeField] private RangeWeaponConfig _rangeConfig;
    [SerializeField] private MeleeAttackTimer _timer;
    [SerializeField] private EnemieScanner _scanner;
    [SerializeField] private Transform _spawnPosition;

    private void Awake()
    {
        _meleeWeaponCollider.enabled = false;
    }

    private void OnEnable ()
    {
        _timer.OnTimeEnd += HideMeleeWeapon;
    }

    private void OnDisable()
    {
        _timer.OnTimeEnd -= HideMeleeWeapon;
    }

    public void Attack(Type weaponType)
    {
        if(weaponType == typeof(MeleeWeaponState))
        {
            MeleeAttack();
            return;
        }
        RangeAttack();
    }

    private void RangeAttack()
    {
        var bullet = Instantiate(_bullet, _spawnPosition.position, _spawnPosition.rotation).GetComponent<Rigidbody2D>();
        bullet.AddForce(transform.up * _rangeConfig.BulletSpeed, ForceMode2D.Impulse);
    }

    private void MeleeAttack()
    {
        if (!_scanner.TryGetEnemie())
        {
            return;
        }
        _timer.enabled = true;
        _meleeWeaponCollider.enabled = true;
        _timer.SetTimer(_meleeConfig.AttackCoolDown);
    }

    private void HideMeleeWeapon()
    {
        _meleeWeaponCollider.enabled = false;
    }

}
