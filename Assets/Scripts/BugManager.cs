using UnityEngine;

namespace OneHourJam363
{
    public class BugManager : MonoBehaviour
{
    public GameObject _bug;
    private Vector2 _move;
    private PlayerController _player;

    void Start()
    {
        Instantiate(_bug);
    }

    void Update()
    {
        Vector2 playerPos = PlayerController.Instance.transform.position;
        Debug.Log(playerPos);
    }
}   
}

