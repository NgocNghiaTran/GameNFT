using Solana.Unity.SDK.Nft;
using Solana.Unity.SDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateNFTS : MonoBehaviour
{
    private void OnEnable()
    {
        Web3.OnNFTsUpdate += OnNFTsUpdate;
    }


    private void OnDisable()
    {
        Web3.OnNFTsUpdate -= OnNFTsUpdate;
    }


    private void OnNFTsUpdate(List<Nft> nfts, int total)
    {
        Debug.Log($"NFTs updated. Total: {total}");
    }
}
