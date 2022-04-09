using UnityEngine;

namespace OneHourJam363
{
    public class BugController : MonoBehaviour
    {
        private Rigidbody2D _rb;

        private void Start()
        {
            
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            FlowerSpawner.Instance.SpawnFlower(collision.contacts[0].point);
            BugManager.instance.Spawn();
            Destroy(gameObject);
        }
    }
}
