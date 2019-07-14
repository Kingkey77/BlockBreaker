using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    
    [SerializeField] int screenWidthInUnits = 16;              //number of units making up the screen width 
    [SerializeField] float maxMousePosInUnits = 15.0f, minMousePosInUnits = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = (Input.mousePosition.x/ Screen.width * screenWidthInUnits);
        
        
        float clampedMousePositionX = Mathf.Clamp(mousePosInUnits, minMousePosInUnits, maxMousePosInUnits);
        Vector2 paddlePos = new Vector2(clampedMousePositionX, transform.position.y);
        transform.position = paddlePos;
    }
}
