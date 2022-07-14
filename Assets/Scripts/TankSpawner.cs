using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tModel = new TankModel();
        TankController tController = new TankController(tModel,tView);
    }
}
