using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ConnectMainCylinder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainCylinder;
    public GameObject MainCylinderOutside;

    public void OnTriggerEnter(Collider other)
    {
        // Открепляем объект от руки
        Interactable interactable = MainCylinderOutside.GetComponent<Interactable>();


        //
        if (other.tag == "MainCylinder") // && interactable != null && interactable.attachedToHand -- нужно добавить эту строку если тестирование будет происходить в самом ВР, а не в сцене юнити
        {
            Debug.Log(other.gameObject.tag);
            interactable.attachedToHand.DetachObject(MainCylinderOutside);
            MainCylinderOutside.SetActive(false);
            MainCylinder.SetActive(true);
        }
    }
}
