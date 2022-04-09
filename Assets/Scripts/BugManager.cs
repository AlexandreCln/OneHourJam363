using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugManager : MonoBehaviour
{
    public GameObject _bug;
    private Vector2 _move;

    void Start()
    {
        Instantiate(_bug);
    }

    void Update()
    {
        
    }
}
