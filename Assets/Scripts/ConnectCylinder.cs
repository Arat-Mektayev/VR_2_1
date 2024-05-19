using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ConnectCylinder : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public GameObject Trigger;
    public GameObject Cylinder;
    public GameObject CylinderOutside;

    private void OnTriggerEnter(Collider other)
    {
        // Открепляем объект от руки
        Interactable interactable = CylinderOutside.GetComponent<Interactable>();


        //
        if (other.gameObject.tag == "Cylinder") // && interactable != null && interactable.attachedToHand
        {
            //Debug.Log(other.gameObject.tag);
            interactable.attachedToHand.DetachObject(CylinderOutside);
            CylinderOutside.SetActive(false);
            Cylinder.SetActive(true);
            Trigger.SetActive(true);
        }
    }
}
