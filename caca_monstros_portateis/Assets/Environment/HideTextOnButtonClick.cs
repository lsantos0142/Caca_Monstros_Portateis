using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTextOnButtonClick : MonoBehaviour
{
    public void onClickButton()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
