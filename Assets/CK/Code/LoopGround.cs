using UnityEngine;

namespace ck.qiekn {
    public class LoopGround : MonoBehaviour {
        [SerializeField] float speed = 1f;
        [SerializeField] float width = 6f;

        private SpriteRenderer spriteRenderer;
        private Vector2 startSize;

        private void Start() {
            spriteRenderer = GetComponent<SpriteRenderer>();
            startSize = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
        }

        private void Update() {
            spriteRenderer.size = new Vector2(spriteRenderer.size.x + speed * Time.deltaTime, spriteRenderer.size.y);

            if (spriteRenderer.size.x > width) {
                spriteRenderer.size = startSize;
            }
        }
    }
}
