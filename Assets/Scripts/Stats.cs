using UnityEngine;

namespace OneHourJam363
{
    public class Stats : MonoBehaviour
    {
        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        public int count;

        public static Stats Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }
    }
}
