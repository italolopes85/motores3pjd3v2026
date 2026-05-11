using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    

    public static Gamemanager instance;
    
    public GameState gameState;
    public static event Action<GameState> OnGameStateChanged;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateGameState(GameState.SelectColor);
        
    }

    public object SelectColor { get; set; }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.SelectColor:
                break;
            case GameState.PlayerTurn:
                break;
            case GameState.EnaemyTurn:
                break;
            case GameState.Victory:
                break;
            case GameState.lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        OnGameStateChanged?.Invoke(newState);
    }

    public GameState State { get; set; }
}
    public enum GameState
    {
       SelectColor,
       PlayerTurn,
       EnaemyTurn,
       Victory,
       lose
    }

