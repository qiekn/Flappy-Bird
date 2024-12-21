using UnityEngine;

namespace ck.qiekn {
    public class Star : MonoBehaviour {
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.gameObject.CompareTag("Player")) {
                Score.Instance.IncreaseAndUpdateScore();
            }
        }
    }
}
