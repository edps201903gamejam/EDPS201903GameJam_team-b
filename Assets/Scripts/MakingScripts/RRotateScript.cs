using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RRotateScript : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    private void OnMouseDrag()
    {
        Vector3 curremtScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(curremtScreenPoint) + this.offset;
        transform.position = currentPosition;
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "RightRotate")
        {
            float z = 0;
            this.gameObject.transform.Rotate(new Vector3(0,0,z + 0.4f));
        }
    }
}
