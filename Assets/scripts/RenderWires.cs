using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
[SelectionBase]
public class RenderWires : MonoBehaviour
{
    private List<Vector3> inputGatePositions;
    private Gate gate;

    private void Start()
    {
        inputGatePositions = new List<Vector3>();
    }

    void Update()
    {
        if (GetComponent<Gate>()?.inputGates.Count == 0 || GetComponent<Gate>()?.inputGates.Count == null) return;

        foreach (Gate gate in GetComponent<Gate>().inputGates)
        {
            inputGatePositions.Add(gate.transform.position);
        }

        foreach (Vector3 gatePos in inputGatePositions)
        {
            Debug.DrawLine(transform.position, gatePos, Color.magenta, 0.01f, true);
        }

        inputGatePositions.Clear();
    }
}
