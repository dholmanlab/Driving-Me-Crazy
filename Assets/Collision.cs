using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Collision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        
        Debug.Log("Move Bitch!");
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("YYYYRRrooommm");
        
    }
}
