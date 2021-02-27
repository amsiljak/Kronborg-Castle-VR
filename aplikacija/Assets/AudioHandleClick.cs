using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandleClick : MonoBehaviour
{
    public GameObject audio;

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
                if(hit.collider.tag == "flowers") {
                    if(audio.activeSelf) audio.SetActive(false);
                    else audio.SetActive(true);
                }
            }
        }
    }
}


