using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;

    private void Update()
    {
        var finalMousePosition = _input.MousePosition - new Vector2(transform.position.x, transform.position.y);
        transform.up = Vector3.Lerp(transform.up, finalMousePosition, Time.deltaTime);
    }
}
