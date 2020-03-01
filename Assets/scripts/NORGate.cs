public class NORGate : Gate
{
    public NORGate(bool state) : base(state) { }

    public override void Interact()
    {
        foreach (Gate gate in inputGates)
        {
            if (gate.ActiveState == true)
            {
                Disable();
                return;
            }
        }
        Enable();
    }
}
