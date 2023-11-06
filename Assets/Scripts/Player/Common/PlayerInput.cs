using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string _horizontalMove;
    [SerializeField] private string _verticalMove;
    [SerializeField] private string _attack;
    [SerializeField] private string _switchWeapon;
    [SerializeField] private Camera _camera;
    [SerializeField] private CurrentWeapon _currentWeapon;

    public event Action OnAttacked;
    public event Action OnWeaponChanged;

    public Vector2 MousePosition { get; private set; }
    public Vector2 MoveDirection { get; private set; }

    private void Update()
    {
        if(Input.GetButtonDown(_attack) && !_currentWeapon.IsAttacked)
        {
            OnAttacked?.Invoke();
        }

        if(Input.GetButtonDown(_switchWeapon))
        {
            OnWeaponChanged?.Invoke();
        }

        MousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        MoveDirection = new Vector2(Input.GetAxis(_horizontalMove), Input.GetAxis(_verticalMove));
    }
}
