using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Image healthBarImage;

    private void Start()
    {
        CollectibleManager.OnHealthValueChanged += CollectibleManager_OnHealthValueChanged;
        UpdateUI(CollectibleManager.Instance.GetMaxHealth());
    }

    private void CollectibleManager_OnHealthValueChanged(int healthValue)
    {
        UpdateUI(healthValue);
    }

    private void UpdateUI(int healthValue)
    {
        float animationDuration = 0.5f;
        int maxHealth = CollectibleManager.Instance.GetMaxHealth();
        healthBarImage.DOFillAmount((float)healthValue / maxHealth, animationDuration);
    }
}
