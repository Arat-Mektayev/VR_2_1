using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ConnectPlate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Plate;
    public GameObject PlateOutside;

    public void OnTriggerEnter(Collider other)
    {
        // Открепляем объект от руки
        Interactable interactable = PlateOutside.GetComponent<Interactable>();


        //
        if (other.tag == "Plate") // && interactable != null && interactable.attachedToHand -- нужно добавить эту строку если тестирование будет происходить в самом ВР, а не в сцене юнити
        {
            Debug.Log(other.gameObject.tag);
            interactable.attachedToHand.DetachObject(PlateOutside);
            PlateOutside.SetActive(false);
            Plate.SetActive(true);
        }
    }
}
