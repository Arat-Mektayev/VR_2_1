using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ConnectDrill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Drill;
    public GameObject DrillOutside;

    public void OnTriggerEnter(Collider other)
    {
        // Открепляем объект от руки
        Interactable interactable = DrillOutside.GetComponent<Interactable>();


        //
        if (other.tag == "Drill") // && interactable != null && interactable.attachedToHand -- нужно добавить эту строку если тестирование будет происходить в самом ВР, а не в сцене юнити
        {
            Debug.Log(other.gameObject.tag);
            interactable.attachedToHand.DetachObject(DrillOutside);
            DrillOutside.SetActive(false);
            Drill.SetActive(true);
        }
    }
}
