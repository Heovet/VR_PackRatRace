using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class buttonPress : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other){
        if (!isPressed){
            button.transform.localPosition = new Vector3(0, -0.03f, 0);
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other){
        button.transform.localPosition = new Vector3(0, 0.015f, 0);
        onRelease.Invoke();
        isPressed = false;
    }
}
