using TMPro;
using UnityEngine;

public class CoinsText : MonoBehaviour
{
    private TMP_Text texto;

    private void Awake()
    {
        texto = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        Debug.Log("CoinsText ativado");
        PlayerObserverManager.OnCoinCollected += AtualizarTexto;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= AtualizarTexto;
    }

    private void AtualizarTexto(int moedas)
    {
        Debug.Log("Recebi o evento: " + moedas);
        texto.text = "Moedas: " + moedas;
    }
}