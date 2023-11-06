using UnityEngine;

public class MeleeWeaponState : MonoBehaviour, IWeaponState
{
    [SerializeField] private GameObject _currentWeapon;

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
