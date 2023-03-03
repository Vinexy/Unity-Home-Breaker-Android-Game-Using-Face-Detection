using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    [SerializeField] GameObject gamePedal;
    Vector3 pedalPozisyonu;
    Vector2 vel;
    private bool checkStick = true;

    void Start()
    {
        pedalPozisyonu = new Vector3(transform.position.x - gamePedal.transform.position.x , transform.position.y - gamePedal.transform.position.y, transform.position.z - gamePedal.transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        BallPedala();
        if (GetComponent<Rigidbody2D>().velocity.magnitude > 10f)
            GetComponent<Rigidbody2D>().velocity = Vector2.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, 10f);
        

    }

    

    private void BallPedala()
    {
        stick();
        
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            checkStick = false;

            GetComponent<Rigidbody2D>().velocity = new Vector2(1.5f, 8f);

            Destroy(GameObject.FindGameObjectWithTag("Throw"));
        }
        
    }

    private void stick()
    {
        if (checkStick)
        {
            Vector3 updatePedal = new Vector3(gamePedal.transform.position.x, gamePedal.transform.position.y, gamePedal.transform.position.z);
            transform.position = updatePedal + pedalPozisyonu;
            

        }
        
    }

    

    


}
