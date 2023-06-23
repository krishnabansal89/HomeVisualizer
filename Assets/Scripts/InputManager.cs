using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
     [SerializeField] private Camera arCam;
    [SerializeField] private ARRaycastManager _raycastManager;
    //[SerializeField] private GameObject arObj;
    private List<ARRaycastHit> _hits = new List<ARRaycastHit>();


     private Touch touch;
    private Pose pose;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.touchCount>0)
       {
                touch = Input.GetTouch(0);

       }
        if (Input.touchCount <= 0 || touch.phase != TouchPhase.Began)
            return;

       

        if (IsPointerOverUI(touch))
        return;

        Instantiate(DataHandler.Instance.furniture, pose.position, pose.rotation);

    }

    bool IsPointerOverUI(Touch touch)
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = new Vector2(touch.position.x, touch.position.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        return results.Count > 0;
    }
}
