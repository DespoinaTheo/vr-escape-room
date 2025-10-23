using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class XRMover : MonoBehaviour
{
    public float moveSpeed = 1.5f;

    private CharacterController characterController; // Character Controller Ref
    private XROrigin xrOrigin;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        xrOrigin = GetComponent<XROrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        // Read keyboard input for horizontal (A/D) and vertical (W/S) movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Create movement vector
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // Convert direction to XR Origin rotation
        Vector3 worldDirection = transform.TransformDirection(direction);

        // Move the CharacterController
        characterController.Move(worldDirection * moveSpeed * Time.deltaTime);
    }
}
