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
        // ���������� ������ �� ����
        Interactable interactable = ButtonOutside.GetComponent<Interactable>();

        
        //
        if (other.gameObject.tag == "ButtonOnOff") // && interactable != null && interactable.attachedToHand -- ����� �������� ��� ������ ���� ������������ ����� ����������� � ����� ��, � �� � ����� �����
        {
            Debug.Log(other.gameObject.tag);
            interactable.attachedToHand.DetachObject(ButtonOutside);
            ButtonOutside.SetActive(false);
            Button.SetActive(true);
        }
    }
}
