using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // if the tag is "Package"
        // then print "picked up package to console"

        if(collision.CompareTag("Package"))
        {
            Debug.Log("Package Acquired");
            hasPackage = true;     
        }

        if(collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package Delivered"); 
            hasPackage = false;    
        }        
    }
}
