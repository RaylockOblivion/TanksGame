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
        CreateTank();
    }

    private void CreateTank()
    {
        Tank t = tankList[1];
        TankModel tModel = new TankModel(t.movementSpeed,t.rotationSpeed,t.tankType,t.color);
        TankController tController = new TankController(tModel,tView);
    }
}
