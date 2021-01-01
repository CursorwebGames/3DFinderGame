using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public Transform player;
    public Transform cam;

    public float sens;
    public float vertMax;

    private Quaternion camDefault;

    private void Start()
    {
        camDefault = cam.localRotation;
    }

    private void Update()
    {
        LookHoriz();
        LookVert();
    }


    private void LookHoriz()
    {
        // playerInput
        float pInput = Input.GetAxis("Mouse X") * sens;// * Time.deltaTime;
        Quaternion rotation = Quaternion.AngleAxis(pInput, Vector3.up);
        player.localRotation *= rotation;
    }

    private void LookVert()
    {
        // playerInput
        float pInput = Input.GetAxis("Mouse Y") * sens;// * Time.deltaTime;
        Quaternion rotation = Quaternion.AngleAxis(pInput, Vector3.left);
        Quaternion delta = cam.localRotation * rotation;
        if (Quaternion.Angle(camDefault, delta) < vertMax) cam.localRotation = delta;
    }
}
