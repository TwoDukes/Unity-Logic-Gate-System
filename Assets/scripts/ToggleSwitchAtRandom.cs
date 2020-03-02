using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Switch))]
public class ToggleSwitchAtRandom : MonoBehaviour
{
    [Range(0,5)]
    public float minDelay = 0.1f;
    [Range(0, 5)]
    public float maxDelay = 1.5f;

    private Switch switchToToggle;

    private void Awake()
    {
        switchToToggle = GetComponent<Switch>();
    }

    private void Start()
    {
        StartCoroutine(ToggleSwitch());
    }

    IEnumerator ToggleSwitch()
    {
        yield return new WaitForSeconds(0.1f);
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minDelay,maxDelay));
            switchToToggle.Interact();
        }
    }
}
