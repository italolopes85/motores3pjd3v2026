using System;
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
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Start()
    {
        LoadScene("splash");
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;
        Debug.Log("Estado Atual Alterado Para: " + CurrentState);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "splash":
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
        if (CurrentState == GameState.Gameplay)
        {
            Debug.Log("Estado: Gameplay rodando no Update.");
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

