using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string _horizontalMove;
    [SerializeField] private string _verticalMove;
    [SerializeField] private string _attack;
    [SerializeField] private string _switchWeapon;

    public Vector2 MoveDirection { get; private set; }

    private void Update()
    {
        MoveDirection = new Vector2(Input.GetAxis(_horizontalMove), Input.GetAxis(_verticalMove));
    }
}
