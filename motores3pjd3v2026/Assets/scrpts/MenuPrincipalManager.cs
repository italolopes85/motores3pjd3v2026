using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject getStartedScene;
    
    public void Play()
    {
        SceneManager.LoadScene("Play");
        SceneManager.LoadScene("GetStarted_Scene");
    }

    public void Skip()
    {
        Debug.Log("Skip");
        Application.Quit();
    }
}
