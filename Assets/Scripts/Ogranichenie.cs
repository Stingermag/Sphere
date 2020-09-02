using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogranichenie : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;
    public GameObject Player;
    public float ygol;
    // Start is called before the first frame update
    void Start()
    {
        ygol = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        X = transform.rotation.x;
        Y = transform.rotation.y;
        Z = transform.rotation.z;
        if (transform.rotation.x < -ygol)
        {
            transform.RotateAround(Player.transform.position, new Vector3(ygol, 0, 0), 50 * Time.deltaTime);
        }
        if (transform.rotation.x > ygol)
        {
            transform.RotateAround(Player.transform.position, new Vector3(-ygol, 0, 0), 50 * Time.deltaTime);
        }


        if (transform.rotation.z < -ygol)
        {
            transform.RotateAround(Player.transform.position, new Vector3(0, 0, ygol), 50 * Time.deltaTime);
        }
        if (transform.rotation.z > ygol)
        {
            transform.RotateAround(Player.transform.position, new Vector3(0, 0, -ygol), 50 * Time.deltaTime);
        }


    }
}
