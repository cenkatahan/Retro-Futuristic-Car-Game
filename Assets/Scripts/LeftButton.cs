using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    public static bool isLeftButtonDown = false;

    public void OnPointerUp() {
        isLeftButtonDown = false;
    }

    public void OnPointerDown() {
        isLeftButtonDown = true;
    }
}
    