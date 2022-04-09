using UnityEngine;

namespace OneHourJam363
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField]
        private Transform _follow;

        private void Update()
        {
            transform.position = new Vector3(_follow.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
