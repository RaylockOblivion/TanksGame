using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tController;

    private float movement, rotation;

    public Rigidbody rb;
    public MeshRenderer[] childs;


    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0, 3, -4);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (movement != 0)
            tController.Move(movement, tController.getTModel().movementSpeed);
        if (rotation != 0)
            tController.Rotate(rotation, tController.getTModel().rotationSpeed);
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController tController)
    {
        this.tController = tController;
    }

    public Rigidbody getRigidBody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        foreach(MeshRenderer i in childs)
        {
            i.material = color;
        }
    }
}
