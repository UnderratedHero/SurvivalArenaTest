using System;
using UnityEngine;

public class CurrentWeapon : MonoBehaviour
{
    [SerializeField] private Collider2D _meleeWeaponCollider;
    [SerializeField] private MeleeWeaponConfig _meleeConfig;
    [SerializeField] private RangeWeaponConfig _rangeConfig;
    [SerializeField] private Timer _timer;
    [SerializeField] private BulletPool _bulletPool;
    private Rigidbody2D _currentFreeBullet;

    public bool IsAttacked { get; private set; }

    private void Awake()
    {
        _meleeWeaponCollider.enabled = false;
    }

    private void OnDisable()
    {
        _timer.OnTimeEnd -= HideMeleeWeapon;
        _timer.OnTimeEnd -= HideBullet;
    }

    public void Attack(Type weaponType)
    {
        IsAttacked = true;
        if (weaponType == typeof(MeleeWeaponState))
        {
            MeleeAttack();
            _timer.OnTimeEnd += HideMeleeWeapon;
            return;
        }
        RangeAttack();
        _timer.OnTimeEnd += HideBullet;
    }

    private void RangeAttack()
    {
        _currentFreeBullet = _bulletPool.CreateBullet();
        _currentFreeBullet.transform.parent = null;
        _currentFreeBullet.AddForce(transform.up * _rangeConfig.BulletSpeed, ForceMode2D.Impulse);
        _timer.SetTimer(_rangeConfig.BulletLifeTime);
    }

    private void MeleeAttack()
    {
        _meleeWeaponCollider.enabled = true;
        _timer.SetTimer(_meleeConfig.AttackCoolDown);
    }

    private void HideBullet()
    {
        IsAttacked = false;
        _currentFreeBullet.gameObject.SetActive(false);
        _currentFreeBullet.transform.parent = transform;
        _currentFreeBullet.transform.position = transform.position;
    }

    private void HideMeleeWeapon()
    {
        IsAttacked = false;
        _meleeWeaponCollider.enabled = false;
    }

}
