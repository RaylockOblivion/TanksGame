using UnityEngine;

public class TankModel {
    private TankController tController;

    public float movementSpeed, rotationSpeed;

    public TankModel(float movementSpeed,float rotationSpeed)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
        
    }

    public void SetTankController(TankController tController)
    {
        this.tController = tController;
    }

}
