using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPreFab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tankPreFab, transform.position, Quaternion.identity);
    }

}
