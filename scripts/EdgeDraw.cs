using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeDraw : MonoBehaviour
{
    public GameObject otherNode;
    private LineRenderer draw;

    public void setUpLine()
    {
        draw = this.gameObject.GetComponent<LineRenderer>();
        draw.positionCount = 2;
        draw.SetPosition(0, this.transform.position);
        draw.SetPosition(1, otherNode.transform.position);
        draw.SetWidth(0.2f, 0.2f);
    }

    private void Start()
    {
        setUpLine();
    }

    private void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            draw.enabled = !draw.enabled;
        }
    }
}
