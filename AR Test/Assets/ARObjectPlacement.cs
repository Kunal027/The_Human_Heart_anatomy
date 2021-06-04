using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARObjectPlacement : MonoBehaviour
{

    public ARSessionOrigin ar_sessionOrigin;
    public List<ARRaycastHit> arRaycastHits = new List<ARRaycastHit>();
    public GameObject heart;

    GameObject instantiatedModel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //detecting the user touch
        //projecting a raycast
        //instantiate the model

        if(Input.GetMouseButton(0))
        {
            bool col = ar_sessionOrigin.GetComponent<ARRaycastManager>().Raycast(Input.mousePosition, arRaycastHits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon);
            if(col)
            {
                if (instantiatedModel == null)
                {
                    Instantiate(heart);

                    foreach (var plane in ar_sessionOrigin.GetComponent<ARPlaneManager>().trackables)
                    {
                        plane.gameObject.SetActive(false);
                    }
                    ar_sessionOrigin.GetComponent<ARPlaneManager>().enabled = false;
                }
                instantiatedModel.transform.position = arRaycastHits[0].pose.position;
            }
        }
    }
}
