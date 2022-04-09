using System.Collections;
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
            Spawn();
        }

        public void WaitAndSpawn()
        {
            StartCoroutine(WaitWaitAndSpawn());
        }

        public IEnumerator WaitWaitAndSpawn()
        {
            yield return new WaitForSeconds(2f);
            Spawn();
        }

        public void Spawn()
        {
            Instantiate(_bug, new Vector2(PlayerController.Instance.transform.position.x, 10f), Quaternion.identity);
        }
    }   
}

