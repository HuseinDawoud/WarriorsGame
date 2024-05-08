using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomPan : MonoBehaviour
{
    Vector3 touch;
    public float zoomMin = 1;
    public float zoomMax = 38;
    public float cameraXMin;
    public float cameraXMax;
    public float cameraYMin;
    public float cameraYMax;
    public float CurRange;

    void Start()
    {
        Camera.main.orthographicSize = zoomMax;
    }

    // Update is called once per frame
    void Update()
    {   
          
        if (Input.GetMouseButtonDown(0))
        {
            touch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroLastPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOneLastPos = touchOne.position - touchOne.deltaPosition;

            float distTouch = (touchZeroLastPos - touchOneLastPos).magnitude;
            float currentDistTouch = (touchZero.position - touchOne.position).magnitude;
            float difference = currentDistTouch - distTouch;
            zoom(difference * 0.2f);
           
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 direction = touch - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += direction;
            Camera.main.transform.position = new Vector3(Mathf.Clamp(Camera.main.transform.position.x, cameraXMin, cameraXMax),
                Mathf.Clamp(Camera.main.transform.position.y, cameraYMin, cameraYMax), Camera.main.transform.position.z);
            cameraXMax += CurRange;
            cameraXMin -= CurRange;
        }
        zoom(Input.GetAxis("Mouse ScrollWheel")* 100f);
       
    }
    void zoom (float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomMin, zoomMax);  
        
    }
}
