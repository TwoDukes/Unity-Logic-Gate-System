public class XNORGate : Gate
{
    public XNORGate(bool state) : base(state) { }

    public override void Interact()
    {
        bool initialInput = inputGates[0].ActiveState;
        for (int i = 1; i < inputGates.Count; i++)
        {
            if (inputGates[i].ActiveState != initialInput)
            {
                Disable();
                return;
            }
        }
        Enable();
    }
}
