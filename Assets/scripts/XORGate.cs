public class XORGate : Gate
{
    public XORGate(bool state) : base(state) { }

    public override void Interact()
    {
        bool initialInput = inputGates[0].ActiveState;
        for(int i = 1; i < inputGates.Count; i++)
        {
            if(inputGates[i].ActiveState != initialInput)
            {
                Enable();
                return;
            }
        }
        Disable();
    }
}
