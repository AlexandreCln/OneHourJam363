using UnityEngine;

namespace OneHourJam363
{
    public class BugManager : MonoBehaviour
    {
        public float speed = 1f;
        public GameObject _bug;
        private Vector2 _move;
        private PlayerController _player;
        private Rigidbody2D _rb;

        void Start()
        {
            Instantiate(_bug);
        }

        void Update()
        {
            Vector2 playerPos = PlayerController.Instance.transform.position;
            Vector2 dir = playerPos - (Vector2)transform.position;



            transform.Translate(dir.normalized * speed * Time.deltaTime);
        }
    }   
}

