using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private EnemieScanner _scanner;
    [SerializeField] private WeaponChange _switch;

    private void OnEnable()
    {
        _input.OnAttacked += Attack;
        _input.OnWeaponChanged += _switch.Change;
    }

    private void OnDisable()
    {
        _input.OnAttacked -= Attack;
        _input.OnWeaponChanged -= _switch.Change;
    }

    private void Attack()
    {
        if(!_scanner.TryGetEnemie())
        {
            return;
        }
    }
}
