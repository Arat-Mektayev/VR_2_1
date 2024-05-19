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
        // ���������� ������ �� ����
        Interactable interactable = MainCylinderOutside.GetComponent<Interactable>();


        //
        if (other.tag == "MainCylinder") // && interactable != null && interactable.attachedToHand -- ����� �������� ��� ������ ���� ������������ ����� ����������� � ����� ��, � �� � ����� �����
        {
            Debug.Log(other.gameObject.tag);
            interactable.attachedToHand.DetachObject(MainCylinderOutside);
            MainCylinderOutside.SetActive(false);
            MainCylinder.SetActive(true);
        }
    }
}
