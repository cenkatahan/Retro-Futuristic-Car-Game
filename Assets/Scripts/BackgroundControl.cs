using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    Animator backgroundAnim;

    // Start is called before the first frame update
    void Start() {
        backgroundAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        HandleBackgroundAnim();
    }


    private void HandleBackgroundAnim() {
        if (Input.GetKeyDown(KeyCode.W) || ForwardButton.isForwardButtonDown) {

            backgroundAnim.SetBool("isMoving", true);
        }
        //else must be crash state
        //else {
        //    backgroundAnim.SetBool("isMoving", false);
        //}
    }
}
