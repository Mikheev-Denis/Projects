using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
   
     public GameObject shelfContent;

     static bool lookingAt;


    private void Start()
    {
        shelfContent.SetActive(false);
    }
    void Update()
    {
             
            
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            shelfContent.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            shelfContent.SetActive(false);
            lookingAt = false;
        }
    }

}

