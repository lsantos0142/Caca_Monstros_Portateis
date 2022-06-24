using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creeper_random : MonoBehaviour
{
    private creeper_ctl charController;

    void Awake()
    {
        charController = GetComponent<creeper_ctl>();
    }

    private void FixedUpdate()
    {
        // Get input values
        int vertical = Mathf.RoundToInt(Random.Range(-1.0f, 1.0f));
        int horizontal = Mathf.RoundToInt(Random.Range(-1.0f, 1.0f));
        charController.ForwardInput = vertical;
        charController.TurnInput = horizontal;
    }
}
