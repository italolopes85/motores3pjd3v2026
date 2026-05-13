using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState CurrentState;

    [Header("Player Input")]
    [SerializeField] private PlayerInput playerInput;

    private void Awake()
    {
        // Singleton
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        ChangeState(GameState.Iniciando);

        // Começa pela Splash
        LoadScene("Splash");
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;

        Debug.Log("Estado Atual: " + CurrentState);
    }

    public void LoadScene(string sceneName)
    {
        // Apenas o GameManager pode trocar cenas
        SceneManager.LoadScene(sceneName);

        switch (sceneName)
        {
            case "Splash":
                ChangeState(GameState.Iniciando);
                break;

            case "MenuPrincipal":
                ChangeState(GameState.MenuPrincipal);
                break;

            case "GetStarted_Scene":
                ChangeState(GameState.Gameplay);

                AssignPlayerInput();
                break;
        }
    }

    private void AssignPlayerInput()
    {
        if (playerInput != null)
        {
            playerInput.ActivateInput();

            Debug.Log("Input alocado ao jogador.");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");

        Application.Quit();
    }
}
