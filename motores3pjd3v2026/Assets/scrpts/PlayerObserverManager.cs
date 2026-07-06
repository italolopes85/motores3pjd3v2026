using System;
using UnityEngine;

public static class PlayerObserverManager
{
    public static Action<int> OnCoinCollected;

    public static void NotifyCoinCollected(int totalCoins)
    {
        OnCoinCollected?.Invoke(totalCoins);
        Debug.Log("Collected Coin2");
    }
}