using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinsText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= UpdateCoins;
    }

    private void UpdateCoins(int totalCoins)
    {
        coinsText.text = "Moedas: " + totalCoins;
    }
}
