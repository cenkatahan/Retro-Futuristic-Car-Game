using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCarControl : MonoBehaviour
{
    private float speed = -1.5f;
    //private const float SCALE_INCREASE_PERSEC = .00025f;
    private const float SCALE_INCREASE_PERSEC = .0004f;


    private void Start() {
        transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {

        //MoveCar();

        transform.Translate(new Vector3(0.4f, 1, 0) * speed * Time.deltaTime);
        transform.localScale += new Vector3(SCALE_INCREASE_PERSEC, SCALE_INCREASE_PERSEC, SCALE_INCREASE_PERSEC);
    }

    private void MoveCar() {
        transform.Translate(new Vector3(0.4f, 1, 0) * speed * Time.deltaTime);
        transform.localScale += new Vector3(SCALE_INCREASE_PERSEC, SCALE_INCREASE_PERSEC, SCALE_INCREASE_PERSEC);
    }
}
