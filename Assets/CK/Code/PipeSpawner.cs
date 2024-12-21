using UnityEngine;

namespace ck.qiekn {
    public class PipeSpawner : MonoBehaviour {
        [SerializeField] float range = 0.3f;
        [SerializeField] float duration = 1.5f;
        [SerializeField] GameObject pipePrefab;

        private float timer;

        private void Update() {
            if (timer > duration) {
                SpawnPipe();
                timer = 0;
            }
            timer += Time.deltaTime;
        }

        public void SpawnPipe() {
            Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-range, range), 0);
            var pipe = Instantiate(pipePrefab, spawnPos, Quaternion.identity);

            Destroy(pipe, 10f);
        }
    }
}
