using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager : MonoBehaviour
{
    public static GateManager Instance { get {return _instance;} }
    private static GateManager _instance = null;

    [Range(0, 5)]
    public float stepTimeDelay = 0.0f;

    private void Awake()
    {
        if(_instance != null)
        {
            Destroy(_instance);
        }
        _instance = this;
    }
}
