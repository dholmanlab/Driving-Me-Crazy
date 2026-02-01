using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        // if the tag is "Package"
        // then print "picked up package to console"

        if(collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package Acquired");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, destroyDelay);

        }

        if(collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package Delivered"); 
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();   
            Destroy(collision.gameObject, destroyDelay);             
        }        
    }
}
