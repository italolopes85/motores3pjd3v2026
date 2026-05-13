using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Botão Play clicado");

        GameManager.Instance.LoadScene("GetStarted_Scene");
    }
}