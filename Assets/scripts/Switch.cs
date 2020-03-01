using UnityEngine;
public class Switch : Gate
{
    public Switch(bool state) : base(state) { }

    private bool startingState = false;

    private void Start()
    {
        if (startingState)
        {
            Interact();
        }
        else
        {
            Interact();
            Interact();
        }
    }

    [ContextMenu("Toggle Switch")]
    public override void Interact()
    {

        if (!_activeState)
            Enable();
        else
            Disable();
    }
}
