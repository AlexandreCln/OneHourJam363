using UnityEngine;

namespace OneHourJam363
{
    public class BugController : MonoBehaviour
    {
        public float speed = 1f;
        private Rigidbody2D _rb;
        private PlayerController _player;

        private void Start()
        {
            _rb.velocity = new Vector2(x * 10f, _rb.velocity.y);
        }

        private void Update()
        {
            Vector2 playerPos = PlayerController.Instance.transform.position;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            FlowerSpawner.Instance.SpawnFlower(collision.contacts[0].point);
            BugManager.instance.Spawn();
            Destroy(gameObject);
        }
    }
}
