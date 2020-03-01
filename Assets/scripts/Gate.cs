using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public abstract class Gate : MonoBehaviour
{
    // PROPS
    public bool ActiveState { get { return _activeState; } }
    protected bool _activeState;
    protected bool _previousState;

    public List<Gate> inputGates;
    [HideInInspector]
    public List<Gate> outputGates;

    public UnityEvent onEnableEvents;
    public UnityEvent onDisableEvents;

    // CONSTRUCTOR / INITIALIZATION
    public Gate(bool state)
    {
        _activeState = state;
        _previousState = state;
    }

    private void Awake()
    {
        outputGates = new List<Gate>();
    }

    private void Start()
    {
        InitializeGates();
    }

    // ABSTRACT METHODS
    public abstract void Interact();

    // METHODS
    protected void Enable()
    {
        _previousState = _activeState;
        _activeState = true;
        onEnableEvents.Invoke();
        Next();
    }
    protected void Disable()
    {
        _previousState = _activeState;
        _activeState = false;
        onDisableEvents.Invoke();
        Next();
    }

    private void Next()
    {
        foreach (Gate gate in outputGates)
        {
            gate.Interact();
        }
    }

    private void InitializeGates()
    {
        
        foreach(Gate gate in inputGates)
        {
            gate.outputGates.Add(this);
        }
    }
}
