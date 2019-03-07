using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ReverseScript : MonoBehaviour
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
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Reverse")
        {
            Vector3 scale = this.gameObject.transform.localScale;

            if(scale.x >= 0){
                scale.x = -scale.x;
            }else if(scale.x < 0){
                scale.x = -scale.x;
            }
            this.gameObject.transform.localScale = scale;
        }
    }

}
