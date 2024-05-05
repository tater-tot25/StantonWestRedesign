using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleView : MonoBehaviour
{
    public bool toggle;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            toggle = !toggle;
            this.GetComponent<Renderer>().enabled = toggle;
        }
    }
}
