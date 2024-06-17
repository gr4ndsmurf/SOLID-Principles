using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;

    private void Start()
    {
        CollectibleManager.OnCoinValueChanged += CollectibleManager_OnCoinValueChanged;
        UpdateCoinUI(CollectibleManager.Instance.GetCoinValue());
    }

    private void CollectibleManager_OnCoinValueChanged(int coinValue)
    {
        UpdateCoinUI(coinValue);
    }

    private void UpdateCoinUI(int coinValue)
    {
        coinText.text = coinValue.ToString();
    }
}
