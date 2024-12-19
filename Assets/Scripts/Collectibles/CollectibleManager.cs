using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance { get; private set; }

    public static Action<int> OnCoinValueChanged;
    public static Action<int> OnHealthValueChanged;

    [Header("Settings")]
    [SerializeField] private int coinValue = 0;
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth = 100;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void CollectCoin()
    {
        coinValue++;
        OnCoinValueChanged?.Invoke(coinValue);
    }

    public void CollectBox()
    {
        coinValue--;
        OnCoinValueChanged?.Invoke(coinValue);
    }

    public void CollectMedkit()
    {
        int healthIncreaseValue = 10;
        currentHealth += healthIncreaseValue;
        currentHealth = Mathf.Min(currentHealth, 100);
        OnHealthValueChanged?.Invoke(currentHealth);
    }

    public void CollectSpike()
    {
        int healthDecreaseValue = 10;
        currentHealth -= healthDecreaseValue;
        currentHealth = Mathf.Max(currentHealth, 0);
        OnHealthValueChanged?.Invoke(currentHealth);
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }

    public int GetCoinValue()
    {
        return coinValue;
    }
}
