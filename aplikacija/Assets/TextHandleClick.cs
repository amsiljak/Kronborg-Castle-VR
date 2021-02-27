using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHandleClick : MonoBehaviour
{
    public GameObject plane11;
    public GameObject plane12;
    public GameObject plane21;
    public GameObject plane22;
    public GameObject plane31;
    public GameObject plane32;
    public GameObject plane41;
    public GameObject plane42;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "Holger") {
                    if(plane11.activeSelf && plane12.activeSelf) {
                        plane11.SetActive(false);
                        plane12.SetActive(false);
                        plane21.SetActive(true);
                        plane22.SetActive(true);
                    }
                    else if(plane21.activeSelf && plane22.activeSelf)
                    {
                        plane21.SetActive(false);
                        plane22.SetActive(false);
                        plane31.SetActive(true);
                        plane32.SetActive(true);
                    }
                    else if(plane31.activeSelf && plane32.activeSelf)
                    {
                        plane31.SetActive(false);
                        plane32.SetActive(false);
                        plane41.SetActive(true);
                        plane42.SetActive(true);
                    }
                    else if(plane41.activeSelf && plane42.activeSelf)
                    {
                        plane41.SetActive(false); 
                        plane42.SetActive(false);
                    }
                    else 
                    {
                        plane11.SetActive(true);
                        plane12.SetActive(true);
                    }
                }
            }
        }
    }
}
