using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> tankList;

    public TankView tView;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void CreateTank(TankTypes tType)
    {
        Tank t;
        switch (tType)
        {
            case TankTypes.BlueTank:
                t = tankList[0];
                break;
            case TankTypes.GreenTank:
                t = tankList[1];
                break;
            case TankTypes.RedTank:
                t = tankList[2];
                break;
            default:
                t = tankList[1];
                break;
        }
        TankModel tModel = new TankModel(t.movementSpeed,t.rotationSpeed,t.tankType,t.color);
        TankController tController = new TankController(tModel,tView);
    }
}
