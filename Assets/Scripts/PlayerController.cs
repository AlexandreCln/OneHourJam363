using UnityEngine;
using UnityEngine.SceneManagement;

namespace OneHourJam363
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController Instance { private set; get; }

        private Rigidbody2D _rb;
        private SpriteRenderer _sr;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _sr = GetComponent<SpriteRenderer>();
            Instance = this;
        }

        private void FixedUpdate()
        {
            var x = Input.GetAxis("Horizontal");
            _rb.velocity = new Vector2(x * 10f, _rb.velocity.y);
            if (_rb.velocity.x > 0f)
            {
                _sr.flipX = false;
            }
            else if (_rb.velocity.x < 0f)
            {
                _sr.flipX = true;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var hit = Physics2D.Raycast(transform.position, Vector2.down, float.PositiveInfinity, ~(1 << 6));
                if (hit.distance > 0f && hit.distance < .6f)
                {
                    _rb.AddForce(Vector2.up * 8f, ForceMode2D.Impulse);
                }
            }
            if (transform.position.y < -5f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Finish"))
            {
                SceneManager.LoadScene("Victory");
            }
        }
    }
}
