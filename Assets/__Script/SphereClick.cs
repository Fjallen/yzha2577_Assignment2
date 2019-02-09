using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereClick : MonoBehaviour
{
    Vector3 temp = new Vector3(0, 2f, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "TheSphere"){
                    Debug.Log("Sphere is clicked by mouse");
                    gameObject.transform.position = new Vector3(0, 2f, 0);
                }
            }
        }
    }
}
