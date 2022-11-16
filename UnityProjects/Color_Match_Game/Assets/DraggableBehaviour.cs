using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;

    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldportPoint(Input.mousePosition);
        draggable = true;
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldportPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }
}
