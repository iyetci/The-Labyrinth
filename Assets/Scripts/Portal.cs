using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Vector3 TeleportPosition;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<SC_FPSController>().enabled = false;
            while (other.transform.position != TeleportPosition) 
                other.transform.position = TeleportPosition;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<SC_FPSController>().enabled = true;
         
        }
    }

}
              
       
   