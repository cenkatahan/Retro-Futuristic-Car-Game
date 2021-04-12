using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnerScript : MonoBehaviour
{
    [HideInInspector] public static GameObject currentLine;

    private const float MAX_TIMER = 20f;
    private const float COUNTDOWN = .1f;
    private const int MAX_LINE_NUMBER = 3;

    public GameObject[] cars;
    public GameObject[] lines;

    private int randomLineNumber;
    private float timer;
    private GameObject leftCar;
    private GameObject midCar;
    private GameObject rightCar;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        timer -= COUNTDOWN;
        if (timer <= 0 && CarControl.isCarMoving) {
            randomLineNumber = Random.Range(0, MAX_LINE_NUMBER);
            currentLine = lines[randomLineNumber];
            Invoke("ProduceCarAndDestroy", .2f);
            timer = MAX_TIMER;
        }

    }

    private void ProduceCarAndDestroy() {

        switch (currentLine.name) {
            case "LeftLine":
                HandlePrefabs(leftCar);
                break;
            case "MidLine":
                HandlePrefabs(midCar);
                break;
            case "RightLine":
                HandlePrefabs(rightCar);
                break;
        }

    }


    private void HandlePrefabs(GameObject carObject) {
        carObject = Instantiate(cars[randomLineNumber], currentLine.transform.position, currentLine.transform.rotation);
        Destroy(carObject, 2.3f);
    }


}
