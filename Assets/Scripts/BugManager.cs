using System.Collections;
using System.Collections.Generic;
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
        _player = PlayerController.Instance;
        
        Instantiate(_bug);
    }

    void Update()
    {
        Vector2 playerPos = _player.transform.position;
        Debug.Log(playerPos);
    }
}   
}

