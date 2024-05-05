using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideObjectOnRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
    }
}
