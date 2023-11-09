using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float senX;
    public float senY;
     
    public Transform orientation;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    private void Start()
    {
       Cursor.LockState = CursorLockMode.Locked;
       Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        float mouseX = Input.GetAxisRaw("mouse X") * Time.deltaTime * senX;
        float mouseY = Input.GetAxisRaw("mouse Y") * Time.deltaTime * senY;


        yRotation += mouseX;

        xRotation -= mouseY;
    }
}
