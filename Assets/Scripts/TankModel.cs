using UnityEngine;
public class TankModel {

    private TankController tController;

    public float movementSpeed, rotationSpeed;

    public TankTypes tType;
    public Material color;

    public TankModel(float movementSpeed,float rotationSpeed,TankTypes tType, Material color)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
        this.tType = tType;
        this.color = color;
    }

    public void SetTankController(TankController tController)
    {
        this.tController = tController;
    }

}
