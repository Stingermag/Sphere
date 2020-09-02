using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveLevel : MonoBehaviour
{
 
    public GameObject Player;
    public GameObject Level;
    public GameObject Ranp1;

    public bool MoveUp;
    public bool MoveDown;
    public bool MoveLeft;
    public bool MoveRight;
    float naklon = 1f;
    int T = 0;
   
    void Start()
    {
        MoveUp = false;
        MoveDown = false;
        var cloneone =  Instantiate(Ranp1, new Vector3(Player.transform.position.x, Player.transform.position.y - 22f, Player.transform.position.z - 20f), Quaternion.identity, Level.transform);

    }

    // Update is called once per frame
    void Update()
    {
       
        //право
        if (Input.GetKeyDown("d"))
        {
            MoveUp = true;
        }
        if (Input.GetKeyUp("d"))
        {
            MoveUp = false;
        }
        //лево
        if (Input.GetKeyDown("a"))
        {
            MoveDown = true;
        }
        if (Input.GetKeyUp("a"))
        {
            MoveDown = false;
        }
        //вперед
        if (Input.GetKeyDown("w"))
        {
            MoveLeft = true;
        }
        if (Input.GetKeyUp("w"))
        {
            MoveLeft = false;
        }
        //назад
        if (Input.GetKeyDown("s"))
        {
            MoveRight = true;
        }
        if (Input.GetKeyUp("s"))
        {
            MoveRight = false;
        }



        if (MoveUp )
        {
            Level.transform.RotateAround(Player.transform.position, Vector3.left, 50 * Time.deltaTime);
        }
        if (MoveDown )
        {
            Level.transform.RotateAround(Player.transform.position, Vector3.right, 50 * Time.deltaTime);
        }
        if (MoveLeft )
        {
            Level.transform.RotateAround(Player.transform.position, Vector3.back, 50 * Time.deltaTime);
        }
        if (MoveRight)
        {
            Level.transform.RotateAround(Player.transform.position, Vector3.forward, 50 * Time.deltaTime);
        }


        if (Player.transform.position.y <= -60f)
        {
            Player.transform.position = new Vector3(0, 15, 0);
            Player.transform.eulerAngles = new Vector3(0, 0, 0);

            Level.transform.position = new Vector3(0, 0, 0);
            Level.transform.eulerAngles = new Vector3(0, 0, 0);
        }

    }







}
