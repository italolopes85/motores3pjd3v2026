using TMPro;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public TMP_Text coinsText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= UpdateCoins;
    }

    private void UpdateCoins(int amount)
    {
        coinsText.text = "Moedas: " + amount;
    }
}