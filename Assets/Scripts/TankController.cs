using UnityEngine;

public class TankController 
{
    private TankModel tModel;
    private TankView tView;

    public TankController(TankModel tModel,TankView tView)
    {
        this.tModel = tModel;
        this.tView = tView;
        this.tModel.SetTankController(this);
        this.tView.SetTankController(this);
        GameObject.Instantiate(tView);
    }
}
