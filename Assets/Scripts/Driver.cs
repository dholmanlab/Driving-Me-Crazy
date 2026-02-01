using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Driver : MonoBehaviour
{
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float steerSpeed = 220f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float regularSpeed = 5f;
    [SerializeField] TMP_Text boostText;   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boostText.gameObject.SetActive(false);        
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

        float moveAmount = move * currentSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);                     
        transform.Rotate(0, 0, steerAmount);

    }
   
    // Logic controlling if we hit a boost, we speed up and destory the boost
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Boost"))
        {
            currentSpeed = boostSpeed;
            boostText.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
    }

    // Logic controlling if we hit a collision, we slow down
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("WorldCollision"))
        {
            boostText.gameObject.SetActive(false);        
            currentSpeed = regularSpeed;            
        }

    } 
}
