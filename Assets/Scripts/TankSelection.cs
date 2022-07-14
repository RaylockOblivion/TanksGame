using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{

    public TankSpawner tSpawner;
    public void BlueTankSelected(){
        Debug.Log("Blue Tank Created");
        tSpawner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }
    public void RedTankSelected()
    {
        tSpawner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }
    public void GreenTankSelected()
    {
        tSpawner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }
}
