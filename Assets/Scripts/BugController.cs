using UnityEngine;

namespace OneHourJam363
{
    public class BugController : MonoBehaviour
    {
        public float speed = 1f;
        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _rb.velocity = (PlayerController.Instance.transform.position - transform.position).normalized * 10f;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            FlowerSpawner.Instance.SpawnFlower(collision.contacts[0].point);
            BugManager.instance.WaitAndSpawn();
            Destroy(gameObject);
        }
    }
}
