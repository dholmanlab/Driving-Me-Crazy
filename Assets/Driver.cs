using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float movespeed =.01f;
    [SerializeField] float steerSpeed = 1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Gamepad.current != null) 
        // { // A controller is connected 
        //     if(Gamepad.current.buttonNorth.isPressed)
        //     {
        //         Debug.Log("Everybody hands go UP.. ");
        //     }

        //     else if(Gamepad.current.buttonSouth.isPressed)
        //     {
        //         Debug.Log("Baby are you DOWN DOWN DOWN ");
        //     }  

        //     if(Gamepad.current.buttonWest.isPressed)
        //     {
        //         Debug.Log("To the LEFT to the LEFT");
        //     }  

        //     else if(Gamepad.current.buttonEast.isPressed)
        //     {
        //         Debug.Log("You got the RIGHT one");
        //     }     
        // }

        float move = 0f;        
        float steer = 0f;

        if(Keyboard.current.upArrowKey.isPressed)
        {
            move = 1f;
        }

        else if(Keyboard.current.downArrowKey.isPressed)
        {
            move = -1f;
        }  

        if(Keyboard.current.leftArrowKey.isPressed)
        {
            steer = 1f;
        }  

        else if(Keyboard.current.rightArrowKey.isPressed)
        {
            steer = -1f;
        } 

        float moveAmount = move * movespeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);                     
        transform.Rotate(0, 0, steerAmount);

    }
    
}
