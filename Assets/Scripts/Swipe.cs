using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Swipe : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public bool MoveUp = false;
    public bool MoveDown = false;
    public bool MoveLeft = false;
    public bool MoveRight = false;

    public GameObject Level;
    public GameObject Player;
    public void OnBeginDrag(PointerEventData eventData)
    {

        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.x > 0)
            {
                MoveDown = false;
                MoveUp = true;
              //  Level.transform.RotateAround(Player.transform.position, Vector3.left, 50 * Time.deltaTime);
            }
            else
            {
                MoveUp = false;
                MoveDown = true;
               // Level.transform.RotateAround(Player.transform.position, Vector3.right, 50 * Time.deltaTime);

            }
        }
        else
        {
            if (eventData.delta.y > 0)
            {
                MoveLeft = true;
                MoveRight = false;
               // Level.transform.RotateAround(Player.transform.position, Vector3.back, 50 * Time.deltaTime);
            }
            else
            {
                MoveLeft = false;
                MoveRight = true;
                //Level.transform.RotateAround(Player.transform.position, Vector3.forward, 50 * Time.deltaTime);

            }
        }



        
        // throw new NotImplementedException ();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (MoveUp)
        {
            Level.transform.RotateAround(Player.transform.position, Vector3.left, 50 * Time.deltaTime);
        }
        if (MoveDown)
        {
            Level.transform.RotateAround(Player.transform.position, Vector3.right, 50 * Time.deltaTime);
        }
        if (MoveLeft)
        {
            Level.transform.RotateAround(Player.transform.position, Vector3.back, 50 * Time.deltaTime);
        }
        if (MoveRight)
        {
            Level.transform.RotateAround(Player.transform.position, Vector3.forward, 50 * Time.deltaTime);
        }
        // throw new NotImplementedException ();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
