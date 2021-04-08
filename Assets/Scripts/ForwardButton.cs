using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForwardButton : MonoBehaviour
{
    public static bool isForwardButtonDown = false;
    private GameObject engineObject;

    private void Start() {
        engineObject = this.gameObject;
        engineObject.SetActive(true);
    }

    public void OnPointerUp() {
        isForwardButtonDown = false;
        engineObject.SetActive(false);
    }

    public void OnPointerDown() {
        isForwardButtonDown = true;
    }

}
