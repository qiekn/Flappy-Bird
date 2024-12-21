using UnityEngine;

namespace ck.qiekn {
    public class MovePipe : MonoBehaviour {
        [SerializeField] float speed = 0.65f;

        private void Update() {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}