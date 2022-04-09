using UnityEngine;

namespace OneHourJam363
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            var x = Input.GetAxis("Horizontal");
            _rb.velocity = new Vector2(x * 10f, _rb.velocity.y);

        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var hit = Physics2D.Raycast(transform.position, Vector2.down, float.PositiveInfinity, ~(1 << 6));
                if (hit.distance > 0f && hit.distance < .6f)
                {
                    _rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
                }
            }
        }
    }
}
