using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class buttonPress : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition -= button.transform.right * 1/10;
            onPress.Invoke();
            presser = other.gameObject;
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (presser == other.gameObject)
        {
            button.transform.localPosition += button.transform.right * 1/10;
            onRelease.Invoke();
            isPressed = false;
        }
    }
}
