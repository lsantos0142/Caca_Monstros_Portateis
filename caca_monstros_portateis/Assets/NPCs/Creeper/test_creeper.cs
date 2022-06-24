using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_creeper : MonoBehaviour
{
    private creeper_ctl charController;

    void Awake()
    {
        charController = GetComponent<creeper_ctl>();
    }

    private void FixedUpdate()
    {
        // Get input values
        int vertical = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));
        int horizontal = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        bool jump = Input.GetKey(KeyCode.Space);
        charController.ForwardInput = vertical;
        charController.TurnInput = horizontal;
        charController.JumpInput = jump;
    }
}
