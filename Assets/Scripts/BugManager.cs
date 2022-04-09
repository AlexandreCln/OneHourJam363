using UnityEngine;

namespace OneHourJam363
{
    public class BugManager : MonoBehaviour
    {
        public static BugManager instance;

        private void Awake()
        {
            instance = this;
        }

        public GameObject _bug;

        void Start()
        {
            Instantiate(_bug, new Vector2(PlayerController.Instance.transform.position.x, 10f), Quaternion.identity);
        }
    }   
}

