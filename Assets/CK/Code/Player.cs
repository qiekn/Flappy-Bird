using UnityEngine;
namespace ck.qiekn {
    public class Player : MonoBehaviour {
        [SerializeField] float velocity = 1.5f;
        [SerializeField] float rotationSpeed = 10f;

        private Rigidbody2D rb;

        private void Start() {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update() {
            if (Input.GetKey(KeyCode.Space)) {
                rb.linearVelocity = Vector2.up * velocity;
            }
        }

        private void FixedUpdate() {
            transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocityY * rotationSpeed);
        }

        private void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject.CompareTag("Obstacle")) {
                GameManager.Instance.GameOver();
            }
        }
    }
}
