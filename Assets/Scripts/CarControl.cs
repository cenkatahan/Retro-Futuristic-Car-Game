using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarControl : MonoBehaviour
{
    public static bool isCarMoving;

    Animator accelerateAnim;

    private Vector3 goLeft;
    private Vector3 goRight;
    private Transform carPos;
    private GameObject playerCar;

    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite carSprite;

    private const float MAP_BORDER = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        accelerateAnim = this.GetComponent<Animator>();
        goLeft = new Vector3(-.02f, 0, 0);
        goRight = new Vector3(.02f, 0, 0);
        isCarMoving = false;
        carPos = this.gameObject.transform;
        playerCar = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        playerCar.GetComponent<SpriteRenderer>().sprite = carSprite;


        if (Input.GetKeyDown(KeyCode.W) || ForwardButton.isForwardButtonDown) {
            accelerateAnim.SetBool("isAccelerate", true);
            isCarMoving = true;            
        }
        // else must be crash state
        //else {
        //    accelerateAnim.SetBool("isAccelerate", false);
        //}

        if(carPos.position.x > -MAP_BORDER) {
            if ((Input.GetKey(KeyCode.A) || LeftButton.isLeftButtonDown) && isCarMoving) {
                playerCar.GetComponent<SpriteRenderer>().sprite = leftSprite;
                playerCar.transform.localScale = new Vector3(.2f, .2f, .2f);
                gameObject.transform.position += goLeft;
            }
        }
        if(carPos.position.x < MAP_BORDER) {
            if ((Input.GetKey(KeyCode.D) || RightButton.isRightButtonDown)  && isCarMoving) {
                playerCar.GetComponent<SpriteRenderer>().sprite = rightSprite;
                playerCar.transform.localScale = new Vector3(.2f, .2f, .2f);
                gameObject.transform.position += goRight;
            }
        }

        
    }


}
