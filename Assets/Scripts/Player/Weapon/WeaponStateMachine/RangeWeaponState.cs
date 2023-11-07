using UnityEngine;

public class RangeWeaponState : MonoBehaviour, IWeaponState, IWeapon
{
    [SerializeField] private GameObject _currentWeapon;
    [SerializeField] private Timer _timer;
    [SerializeField] private RangeWeaponConfig _config;
    [SerializeField] private BulletPool _bulletPool;
    private Rigidbody2D _currentFreeBullet;
    private bool _isAttacked;

    private void OnDisable()
    {
        _timer.OnTimeEnd -= Hide;
    }

    public void Attack()
    {
        if(_isAttacked )
        {
            return;
        }
        _isAttacked = true;
        _timer.OnTimeEnd += Hide;
        _timer.SetTimer(_config.BulletLifeTime);
        _currentFreeBullet = _bulletPool.CreateBullet();
        _currentFreeBullet.transform.parent = null;
        _currentFreeBullet.AddForce(transform.up * _config.BulletSpeed, ForceMode2D.Impulse);
    }

    public void Hide()
    {
        _isAttacked = false;
        _currentFreeBullet.gameObject.SetActive(false);
        _currentFreeBullet.transform.parent = transform;
        _currentFreeBullet.transform.position = transform.position;
    }

    public void Enter()
    {
        _currentWeapon.SetActive(true);
    }

    public void Exit()
    {
        _currentWeapon.SetActive(false);
    }

    public void OnUpdate()
    {
    }
}
