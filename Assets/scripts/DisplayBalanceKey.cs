using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Solana.Unity.SDK;
using static Solana.Unity.SDK.Web3;
using UnityEngine.UI;
using System.Globalization;

public class DisplayBalanceKey : MonoBehaviour
{
    private Text displayBalance;
    // Start is called before the first frame update
    void Start()
    {
        displayBalance = GetComponent<Text>();
    }

    private void OnEnable()
    {
        Web3.OnBalanceChange += OnBalanceChange;
    }

    private void OnDisable()
    {
        Web3.OnBalanceChange -= OnBalanceChange;
    }

    private void OnBalanceChange(double solBalance)
    {
        displayBalance.text = "Balance: " + solBalance.ToString(CultureInfo.InvariantCulture);
    }
}
