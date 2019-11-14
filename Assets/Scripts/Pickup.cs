using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int coins;
    // Start is called before the first frame update
    void Update()
    {
        Vector3 rotation = new Vector3(15, 30, 45) * Time.deltaTime;
        transform.Rotate(rotation);
    }

}
