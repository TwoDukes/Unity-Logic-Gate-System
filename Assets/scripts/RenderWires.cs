using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
[SelectionBase]
public class RenderWires : MonoBehaviour
{
    private Gate gate;

    void Update()
    {
        foreach (Gate gate in GetComponent<Gate>().inputGates)
        {
            Debug.DrawLine(transform.position, gate.transform.position, gate.ActiveState ? Color.green : Color.red, 0.01f, true);
        }

    }
}
