using UnityEngine;
using System.Collections;

public class DoorObject : MonoBehaviour
{
    public GameObject noteUI;
    public GameObject pickUpText;
    public bool inReach;
    public bool isNoteRead = false;

    void Start(){
        noteUI.SetActive(false);
        pickUpText.SetActive(false);
        inReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        inReach = true;
        pickUpText.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {
      
    }

    void OnTriggerExit(Collider other)
    {
        inReach = false;
        pickUpText.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            if (noteUI.activeSelf)
            {
                noteUI.SetActive(false);
                pickUpText.SetActive(false); 
                isNoteRead = true; 

                if (isNoteRead)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                noteUI.SetActive(true);
                pickUpText.SetActive(false);
            }
        }
    }
}
