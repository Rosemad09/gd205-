using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsPickup : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;


    [SerializeField] private LayerMask PickupMask;//if a object has a certain tag,it can be picked up.
    [SerializeField] private Camera PlayerCamera;// the camera being used for raycasting 
    [SerializeField] private Transform PickupTarget;//where the object will be floating at
    [Space]
    [SerializeField] private float PickupRange;//range where the character can pick up items
    private Rigidbody CurrentObject;//objects need a rigid body to be picked up

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))//if u press e
        {

            if(CurrentObject)
            {
                CurrentObject.useGravity = true;//the object will have gravity 
                CurrentObject = null;//will can
                return;
            }

            Ray CameraRay = PlayerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));//creats a ray in the center of the camera
            if(Physics.Raycast(CameraRay, out RaycastHit HitInfo, PickupRange, PickupMask))//checks if the object hits the ray with a certain range and mask. 
            {
                CurrentObject = HitInfo.rigidbody;//makes a reference to the rigidbody of the hit object.
                CurrentObject.useGravity = false;//disable gravity for the object thats picked up
                source.PlayOneShot(clip);//plays a sound when picked up.

            }
        }
    }

    void FixedUpdate()
    {
        if(CurrentObject)//while holding an object,
        {
            Vector3 DirectionToPoint = PickupTarget.position - CurrentObject.position;//calculates the direction from the object point to the target position.
            float DistanceToPoint = DirectionToPoint.magnitude;//distance to the target position.

            CurrentObject.velocity = DirectionToPoint * 12f * DistanceToPoint;//the speed at when the object comes to the target position.
        }
    }
}