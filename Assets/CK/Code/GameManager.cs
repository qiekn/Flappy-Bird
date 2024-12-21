using UnityEngine;
using UnityEngine.SceneManagement;

namespace ck.qiekn {
    public class GameManager : MonoBehaviour {
        public static GameManager Instance;

        [SerializeField] GameObject gameOverCanvas;

        private void Awake() {
            if (Instance == null) {
                Instance = this;
            }
        }

        private void Start() {
            gameOverCanvas.SetActive(false);
            Time.timeScale = 1f;
            Application.targetFrameRate = 60;
            QualitySettings.vSyncCount = 1;
        }

        public void GameOver() {
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0f;
        }

        public void RestartGame() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
