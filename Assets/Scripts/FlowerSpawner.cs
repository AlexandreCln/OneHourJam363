using UnityEngine;

namespace OneHourJam363
{
    public class FlowerSpawner : MonoBehaviour
    {
        public static FlowerSpawner Instance;

        private void Awake()
        {
            Instance = this;
        }

        [SerializeField]
        private GameObject[] _flowers;

        public void SpawnFlower(Vector3 pos)
        {
            Instantiate(_flowers[Random.Range(0, _flowers.Length)], pos, Quaternion.identity);
        }
    }
}
