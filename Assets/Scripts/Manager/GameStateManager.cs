using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    [HideInInspector]
    public static GameStateManager _instance;

    public GameStates gameState;

    public enum GameStates
    {
        Creation = 0,
        Inn = 1,
        Fight = 2,
        LevelUp = 3
    }

    void CheckState() {
        string sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName) {
            case "CreationScene":
                gameState = GameStates.Creation;
                break;
            case "InnScene":
                gameState = GameStates.Inn;
                break;
            case "FightScene":
                gameState = GameStates.Fight;
                break;
            case "LvlUpScene":
                gameState = GameStates.LevelUp;
                break;
        }
    }

    void Awake() {
        _instance = this;
        gameState = GameStates.Creation;
        DontDestroyOnLoad(gameObject);
        CheckState();
    } 

}
