using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Image _healthUI;
    [SerializeField] private PlayerConfig _config;
    [SerializeField] private PlayerHealth _health;
    [SerializeField] private GameObject _endgameText;

    private void OnEnable()
    {
        _health.OnDecrease += UpdateHealthBar;
    }

    private void OnDisable()
    {
        _health.OnDecrease -= UpdateHealthBar;
    }

    private void UpdateHealthBar()
    {
        _healthUI.fillAmount = _health.Current / _config.MaxHealthPoints;
        if (_healthUI.fillAmount == _config.MinHealthPoints)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        _endgameText.SetActive(true);
    }
}
