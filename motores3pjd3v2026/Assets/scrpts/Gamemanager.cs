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
        UpdateGameState(GameState, Selector);
    }
    public void Update(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.SelectColor:
                HandheldSelectColor();
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
    
}
    public enum GameState
    {
       SelectColor,
       PlayerTurn,
       EnaemyTurn,
       Victory,
       lose
    }

