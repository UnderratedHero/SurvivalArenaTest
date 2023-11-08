using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogicUI : MonoBehaviour
{
    [SerializeField] private Button _restartButton;

    private void Awake()
    {
        _restartButton.onClick.AddListener(() => SceneManager.LoadScene("Game"));
    }
}
