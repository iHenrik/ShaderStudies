using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CameraTranslation();
    }

    private void CameraTranslation()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(this.transform.position.x + (horizontalInput * Time.deltaTime * movementSpeed), this.transform.position.y, this.transform.position.z + (verticalInput * Time.deltaTime * movementSpeed));

        this.transform.position = movement;
    }
}
