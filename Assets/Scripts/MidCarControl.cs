using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidCarControl : MonoBehaviour
{
    private float speed = -2;
    private const float SCALE_INCREASE_PERSEC = .0005f;

    private void Start() {
        transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        transform.localScale += new Vector3(SCALE_INCREASE_PERSEC, SCALE_INCREASE_PERSEC, SCALE_INCREASE_PERSEC);
    }
}
