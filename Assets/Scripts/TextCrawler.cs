using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCrawler : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 20f;
    
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * _scrollSpeed * Time.deltaTime);
    }
}
