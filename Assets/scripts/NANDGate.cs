public class NANDGate : Gate
{
    public NANDGate(bool state) : base(state) { }

    public override void Interact()
    {
        foreach (Gate gate in inputGates)
        {
            if (gate.ActiveState == false)
            {
                Enable();
                return;
            }
        }
        Disable();
    }
}
