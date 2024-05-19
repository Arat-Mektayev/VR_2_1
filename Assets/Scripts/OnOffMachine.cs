using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffMachine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Drill;
    public GameObject Lamp;

    public void OnTriggerEnter(Collider other)
    {
        Renderer rend = Lamp.GetComponent<Renderer>();

        if (other.tag == "OnOff" && rend.material.color != Color.yellow)
        {

            rend.material.color = Color.yellow;
        }
        else
        {
            rend.material.color = Color.gray;
        }
    }

    void Update()
    {
        Renderer rend = Lamp.GetComponent<Renderer>();

        if (rend.material.color == Color.yellow && Drill.activeSelf == true)
        {
            Drill.transform.Rotate(0, 0, -100);
        }
    }
}
