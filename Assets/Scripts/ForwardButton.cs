using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardButton : MonoBehaviour
{
    public static bool isForwardButtonDown = false;

    public void OnPointerUp() {
        isForwardButtonDown = false;
    }

    public void OnPointerDown() {
        isForwardButtonDown = true;
    }

}
