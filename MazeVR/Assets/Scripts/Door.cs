using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Keys myKey;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (myKey.pickedUp == true)
            {
                //gameObject.SetActive(false);
                var thedoor = GameObject.FindWithTag("SF_Door");
                thedoor.GetComponent<Animation>().Play("open");
               
            }
        }
    }
}
