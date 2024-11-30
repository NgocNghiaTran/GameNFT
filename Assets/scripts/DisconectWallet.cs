using HplEdgeClient.Types;
using Solana.Unity.SDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System;

public class DisconectWallet : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button btnConnectWallet;
    [SerializeField] private UnityEngine.UI.Button btnDisConnectWallet;
    [SerializeField] private GameObject textPublicKey;
    [SerializeField] private GameObject textBalanceKey;

    private void Start()
    {
        btnDisConnectWallet.onClick.AddListener(Web3.Instance.Logout);
    }
    private void OnEnable()
    {
        Web3.OnLogin += OnLogin;
        Web3.OnLogout += OnLogout;
    }

    private void OnDisable()
    {
        Web3.OnLogin -= OnLogin;
        Web3.OnLogout -= OnLogout;
    }

    private void OnLogout()
    {
        btnConnectWallet.gameObject.SetActive(true);
        btnDisConnectWallet.gameObject.SetActive(false);
        textPublicKey.SetActive(false);
        textBalanceKey.SetActive(false);
       
    }

    private void OnLogin(Solana.Unity.Wallet.Account account)
    {
        btnConnectWallet.gameObject.SetActive(false);
        btnDisConnectWallet.gameObject.SetActive(true);
        textPublicKey.SetActive(true);
        textBalanceKey.SetActive(true);
    }
}
