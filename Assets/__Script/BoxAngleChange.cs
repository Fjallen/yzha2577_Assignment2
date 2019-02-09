using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAngleChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "TheBox" || hit.transform.name == "Side1" || hit.transform.name == "Side2" || hit.transform.name =="Side3" || hit.transform.name =="Side4")
                {
                    Debug.Log("Box is Hit by Mouse");
                    gameObject.transform.Rotate(-30f, 5f, 10f);
                }
            }
        }
    }
}