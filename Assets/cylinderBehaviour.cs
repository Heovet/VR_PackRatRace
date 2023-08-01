using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderBehaviour : MonoBehaviour
{
    public float speed;
    private bool isMoving;
    private int counter;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        counter = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMoving){
            //move down until counter reaches 49
            if (0 <= counter && counter <= 49){
                transform.Translate(Vector3.down * Time.fixedDeltaTime * speed);
            }
            //turn around
            else if (50 <= counter && counter <= 99){
                transform.Translate(Vector3.up * Time.fixedDeltaTime * speed);
            }
            //stop at counter == 100
            else if (counter >= 100){
                isMoving = false;
            }
            counter += 1;
        }
    }

    public void cycleCylinder(){
        counter = 0;
        isMoving = true;
    }
}
