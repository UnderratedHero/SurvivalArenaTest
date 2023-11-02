using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;

    private void Update()
    {
        var direction = _input.MousePosition - new Vector2(transform.position.x, transform.position.y);
        transform.up = Vector3.Lerp(transform.up, direction, Time.deltaTime);
    }
}
