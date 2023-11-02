using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string _horizontalMove;
    [SerializeField] private string _verticalMove;
    [SerializeField] private string _attack;
    [SerializeField] private string _switchWeapon;
    [SerializeField] private Camera _camera;

    public Vector2 MousePosition { get; private set; }
    public Vector2 MoveDirection { get; private set; }

    private void Update()
    {
        MousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        MoveDirection = new Vector2(Input.GetAxis(_horizontalMove), Input.GetAxis(_verticalMove));
    }
}
