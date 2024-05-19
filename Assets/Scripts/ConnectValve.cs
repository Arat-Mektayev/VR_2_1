using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ConnectValve : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Valve;
    public GameObject ValveOutside;

    public void OnTriggerEnter(Collider other)
    {
        // ���������� ������ �� ����
        Interactable interactable = ValveOutside.GetComponent<Interactable>();


        //
        if (other.tag == "Valve") // && interactable != null && interactable.attachedToHand -- ����� �������� ��� ������ ���� ������������ ����� ����������� � ����� ��, � �� � ����� �����
        {
            Debug.Log(other.gameObject.tag);
            interactable.attachedToHand.DetachObject(ValveOutside);
            ValveOutside.SetActive(false);
            Valve.SetActive(true);
        }
    }
}
