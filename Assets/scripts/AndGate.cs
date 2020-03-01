public class AndGate : Gate
{
    public AndGate(bool state) : base(state) { }

    public override void Interact()
    {
        foreach (Gate gate in inputGates)
        {
            if (gate.ActiveState == false)
            {
                Disable();
                return;
            }
        }
        Enable();
    }
}
