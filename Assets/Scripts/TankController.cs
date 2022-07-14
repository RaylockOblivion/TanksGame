using UnityEngine;

public class TankController 
{
    private TankModel tModel;
    private TankView tView;
    private Rigidbody rb;

    public TankController(TankModel tModel,TankView tView)
    {
        this.tModel = tModel;
        this.tView = GameObject.Instantiate<TankView>(tView);
        this.tModel.SetTankController(this);
        this.tView.SetTankController(this);
        rb = this.tView.getRigidBody();
    }

    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = tView.transform.forward * movement * movementSpeed;
    }
    public void Rotate(float rotation, float rotationSpeed)
    {
        Vector3 vector = new Vector3(0, rotation * rotationSpeed, 0);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel getTModel()
    {
        return tModel;
    }
}
