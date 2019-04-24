using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWithInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    // Start is called beb  fore the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosition = Input.mousePosition.x / Screen.width * screenWithInUnits;
        Vector2 paddlePosition = new Vector2(transform.position.x, 
                                             transform.position.y);

        paddlePosition.x = Mathf.Clamp(mousePosition, minX, maxX);
        transform.position = paddlePosition;
    } 
}
