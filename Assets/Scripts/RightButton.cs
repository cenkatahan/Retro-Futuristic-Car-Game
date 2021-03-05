using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    public static bool isRightButtonDown = false;

    public void OnPointerUp() {
        isRightButtonDown = false;
    }

    public void OnPointerDown() {
        isRightButtonDown = true;
    }
}
