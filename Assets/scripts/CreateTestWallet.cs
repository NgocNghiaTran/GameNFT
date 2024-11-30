using Solana.Unity.SDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTestWallet : MonoBehaviour
{
    public void CreateAccountWallet()
    {
        Web3.Instance.CreateAccount("4LGQ5vTYGgX5rewK9CUuSVfNRPQ5Co3qz6ZPeLWZqapKdrXPMNcfyp2my7nkefSR9RVPpETLBXxFwaSWqBZGypVt", "testsol");
    }
}
