using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnerScript : MonoBehaviour
{
    [HideInInspector] public static GameObject currentLine;


    public GameObject[] cars;
    public GameObject[] lines;

    private int randomLineNumber;
    private float timer;
    private const float MAX_TIMER = 30f;
    private const float COUNTDOWN = .1f;
    private GameObject leftCar;
    private GameObject midCar;
    private GameObject rightCar;


    // Update is called once per frame
    void Update() {
        timer -= COUNTDOWN;
        if (timer <= 0 && CarControl.isCarMoving) {
            randomLineNumber = Random.Range(0, 3);
            currentLine = lines[randomLineNumber];
            Invoke("ProduceCarAndDestroy", 2.5f);
            timer = MAX_TIMER;
        }

    }

    void ProduceCarAndDestroy() {

        switch (currentLine.name) {
            case "LeftLine":
                leftCar = Instantiate(cars[randomLineNumber], currentLine.transform.position, currentLine.transform.rotation);
                Destroy(leftCar, 3f);
                //HandlePrefab(leftCar);
                break;
            case "MidLine":
                midCar = Instantiate(cars[randomLineNumber], currentLine.transform.position, currentLine.transform.rotation);
                Destroy(midCar, 3f);
                //HandlePrefab(midCar);
                break;
            case "RightLine":
                rightCar = Instantiate(cars[randomLineNumber], currentLine.transform.position, currentLine.transform.rotation);
                Destroy(rightCar, 3f);
                //HandlePrefab(rightCar);
                break;
        }

    }

    private void HandlePrefab(GameObject InstantiatedObject) {

        InstantiatedObject = Instantiate(cars[randomLineNumber], currentLine.transform.position, currentLine.transform.rotation);
        Destroy(InstantiatedObject, 3f);

    }
 
}
