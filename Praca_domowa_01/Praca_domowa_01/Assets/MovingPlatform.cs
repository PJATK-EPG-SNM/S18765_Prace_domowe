using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public float reset;

    public Transform movingPlatform, position1, position2;
    public Vector2 newPosition;
    public string currentState; 


    // Start is called before the first frame update
    void Start()
    {
        Change();
    }

    // Update is called once per frame
    void Update()
    {
        movingPlatform.position = Vector2.Lerp(movingPlatform.position, newPosition, speed * Time.deltaTime);

    }

    void Change()
    {
        if (currentState == "Moving to 1")
        {
            currentState = "Moving to 2";
            newPosition = position2.position;
        }
        else if (currentState == "Moving to 2")
        {
            currentState = "Moving to 1";
            newPosition = position1.position;
        }
    
        else if (currentState == "")
        { 
            currentState = "Moving to 2";
            newPosition = position2.position;
        }
        Invoke("Change", reset);
    }

}
