using UnityEngine;
using Unity.XR.CoreUtils;
using System.Collections.Generic;
using UnityEngine.XR;
public class TabManager : MonoBehaviour
{
    private int tabPressCount = 0;
    private XRMover xRMover; // Component Ref

    // Start is called before the first frame update
    void Start()
    {
        xRMover = GetComponent<XRMover>();

        xRMover.enabled = false;
        // XR Origin movement starts with Character Controller (even though headset mode is activated by default)
    }

    // Update is called once per frame
    void Update()
    {
        // Tab Detection
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            tabPressCount++;

            if (tabPressCount % 3 == 0)
            {
                xRMover.enabled = true; // XR Origin movement is controlled by XRMover script
            
                Debug.Log("XRMover is activated");
            }
            else
            {
                xRMover.enabled = false; // // XR Origin movement is controlled by Character Controller
                
                Debug.Log("XRMover is disactivated");
            }
        }
    }
}
