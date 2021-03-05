﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarControl : MonoBehaviour
{
    Animator accelerateAnim;

    private Vector3 goLeft;
    private Vector3 goRight;
    private bool isMoving;
    private Transform carPos;
    private GameObject playerCar;
    


    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite carSprite;

    // Start is called before the first frame update
    void Start()
    {
        accelerateAnim = this.GetComponent<Animator>();
        goLeft = new Vector3(-.01f, 0, 0);
        goRight = new Vector3(.01f, 0, 0);
        isMoving = false;
        carPos = this.gameObject.transform;
        playerCar = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        playerCar.GetComponent<SpriteRenderer>().sprite = carSprite;


        if (Input.GetKeyDown(KeyCode.W) || ForwardButton.isForwardButtonDown) {
            accelerateAnim.SetBool("isAccelerate", true);
            isMoving = true;            
        }
        // else must be crash state
        //else {
        //    accelerateAnim.SetBool("isAccelerate", false);
        //}

        if(carPos.position.x > -3.0f) {
            if ((Input.GetKey(KeyCode.A) || LeftButton.isLeftButtonDown) && isMoving) {
                playerCar.GetComponent<SpriteRenderer>().sprite = leftSprite;
                playerCar.transform.localScale = new Vector3(.23f, .23f, .23f);
                gameObject.transform.position += goLeft;
            }
        }
        if(carPos.position.x < 3.0f) {
            if ((Input.GetKey(KeyCode.D) || RightButton.isRightButtonDown)  && isMoving) {
                playerCar.GetComponent<SpriteRenderer>().sprite = rightSprite;
                playerCar.transform.localScale = new Vector3(.23f, .23f, .23f);
                gameObject.transform.position += goRight;
            }
        }

        
    }


}