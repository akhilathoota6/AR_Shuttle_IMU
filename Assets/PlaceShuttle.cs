using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class PlaceShuttle : MonoBehaviour
{
    public GameObject shuttlePrefab;

    private GameObject spawnedShuttle;
    private ARRaycastManager raycastManager;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (spawnedShuttle != null)
            return;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;
                spawnedShuttle = Instantiate(shuttlePrefab, hitPose.position, hitPose.rotation);
            }
        }
    }
}

