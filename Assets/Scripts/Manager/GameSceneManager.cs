using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour {

    [HideInInspector]
    public static GameSceneManager _instance;

    public SceneManager sceneManager;

    public Scene ActualScene;

    void Awake()
    {
        _instance = this;
        this.sceneManager = new SceneManager();
        DontDestroyOnLoad(gameObject);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisabled()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ActualScene = scene;
    }

}
