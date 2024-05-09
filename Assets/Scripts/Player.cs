using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovement _movement;
    [SerializeField] private Health _health;

    public void OnHealthChanged(int value)
    {
        if (isDead)
        {
            Destroy(gameObject);

            Debug.Log("Игрок умер");
        }
    }

    public void AddHealth(int value)
    {
        _health.TakeHealing(value);
    }

    public void RemoveHealth(int value)
    {
        _health.TakeDamage(value);
    }

    private void OnEnable()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.Changed -= OnHealthChanged;
    }

    private bool isDead => _health.CurrentHealth <= 0;
}
