using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ConnectButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Button;
    public GameObject ButtonOutside;

    private void OnTriggerEnter(Collider other)
    {
        // Открепляем объект от руки
        Interactable interactable = ButtonOutside.GetComponent<Interactable>();

        
        //
        if (other.gameObject.tag == "ButtonOnOff") // && interactable != null && interactable.attachedToHand -- нужно добавить эту строку если тестирование будет происходить в самом ВР, а не в сцене юнити
        {
            Debug.Log(other.gameObject.tag);
            interactable.attachedToHand.DetachObject(ButtonOutside);
            ButtonOutside.SetActive(false);
            Button.SetActive(true);
        }
    }
}
