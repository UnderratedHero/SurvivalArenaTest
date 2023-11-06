using UnityEngine;

public class WeaponSentry : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private WeaponStateMachine _weaponStateMachine;
    [SerializeField] private CurrentWeapon _currentWeapon;

    private void OnEnable()
    {
        _input.OnAttacked += Attack;
        _input.OnWeaponChanged += Change;
    }

    private void OnDisable()
    {
        _input.OnAttacked -= Attack;
        _input.OnWeaponChanged -= Change;
    }

    public void Change()
    {
        if(_weaponStateMachine.GetCurrentState() != typeof(MeleeWeaponState))
        {
            _weaponStateMachine.SetState(_weaponStateMachine.GetState<MeleeWeaponState>());
            return;
        }
        _weaponStateMachine.SetState(_weaponStateMachine.GetState<RangeWeaponState>());
    }

    private void Attack()
    {
        _currentWeapon.Attack(_weaponStateMachine.GetCurrentState());
    }
}
