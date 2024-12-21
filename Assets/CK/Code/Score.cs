using TMPro;
using UnityEngine;

namespace ck.qiekn {
    public class Score : MonoBehaviour {
        public static Score Instance;

        [SerializeField] TextMeshProUGUI currentScore;
        [SerializeField] TextMeshProUGUI highestScore;

        private int score;

        private void Awake() {
            if (Instance == null) {
                Instance = this;
            }
        }

        private void Start() {
            currentScore.text = score.ToString();
            highestScore.text = PlayerPrefs.GetInt("HighestScore").ToString();
        }

        private void UpdateHighestScore() {
            if (score > PlayerPrefs.GetInt("HighestScore")) {
                PlayerPrefs.SetInt("HighestScore", score);
                highestScore.text = score.ToString();
            }
        }

        public void IncreaseAndUpdateScore() {
            score++;
            currentScore.text = score.ToString();
            UpdateHighestScore();
        }
    }
}
