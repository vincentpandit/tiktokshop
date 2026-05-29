using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {

        public static GameManager Instance;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(transform.parent.gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(transform.parent);
        }
        
        private void Start()
        {
            _currentGameState = gameStateAtStart;
        }
        
        #region GameState

        [SerializeField] private GameState gameStateAtStart;

        private enum GameState
        {
            Game,
            Menu
        }

        private GameState _currentGameState;
        private GameState CurrentGameState
        {
            get => _currentGameState;
            set
            {
                if (_currentGameState == value) 
                    return;
                
                _currentGameState = value;
                SceneManager.LoadScene(GetSceneByState());
            }
        }

        private string GetSceneByState()
        {
            return CurrentGameState switch
            {
                GameState.Game => "Game",
                GameState.Menu => "Menu",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
        #endregion

        public void Play()
        {
            CurrentGameState = GameState.Game;
        }
        
        public void Exit()
        {
            Application.Quit();
        }
        
    }
}
