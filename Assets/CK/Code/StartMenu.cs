using UnityEngine;
using UnityEngine.SceneManagement;

namespace ck.qiekn {
    public class StartMenu : MonoBehaviour {
        public void Play() {
            Debug.Log("Game Started.");
            SceneManager.LoadScene(1);
        }

        public void Share() {
            Debug.Log("Share");
        }

        public void Settings() {
            Debug.Log("Settings");
        }
    }
}
