using HplEdgeClient.Types;
using Solana.Unity.SDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Solana.Unity.Rpc.Models;


public class DisplayPublicKey : MonoBehaviour
{

    private Text displayPublicKey;
    // Start is called before the first frame update
    void Start()
    {
        displayPublicKey = GetComponent<Text>();
    }

    private void OnEnable()
    {
        Web3.OnWalletChangeState += WalletChanged;
    }

    private void OnDisable()
    {
        Web3.OnWalletChangeState -= WalletChanged;
    }

    private void WalletChanged()
    {
        if (Web3.Account == null) return;
        string pk = Web3.Account.PublicKey.ToString();
        displayPublicKey.text = $"{pk.Substring(0, 3)}...{pk.Substring(pk.Length - 3)}";
        Debug.Log($"Logged in with: {pk}");
    }
}
