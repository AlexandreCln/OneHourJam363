using UnityEngine;
using UnityEngine.UI;

namespace OneHourJam363
{
    public class Stats : MonoBehaviour
    {
        public Image _heart1;
        public Image _heart2;
        public Image _heart3;
        
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

        private void Update()
        {
            if (count > 3)
                return;
            if (count == 1)
                _heart3.enabled = false;
            if (count == 2)
                _heart2.enabled = false;
            if (count == 3)
                _heart1.enabled = false;
        }
    }
}
