using UnityEngine;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {

        public static LevelManager Instance;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
                return;
            }

            Instance = this;
        }
        
        public void OnPlayButtonPressed()
        {
            GameManager.Instance.Play();
        }
        
        public void OnExitButtonPressed()
        {
            GameManager.Instance.Exit();
        }
    }
}
