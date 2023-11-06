using UnityEngine;

public class TriggerResize : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _boxCollider;
    [SerializeField] private Camera _camera;

    private void Awake()
    {
        var height = _camera.orthographicSize * 2;
        var width = height * _camera.aspect;
        _boxCollider.size = new Vector3(width, height,0);
    }
}
