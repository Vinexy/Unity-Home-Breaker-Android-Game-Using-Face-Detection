using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class pedal : MonoBehaviour
{

    //[SerializeField] float ekranGenisligiUnitCinsinden = 15f;
    //private float xMin = 1f, xMax = 21f;
    private Rigidbody2D rigidbodyPedal;

    void Start()
    {
        rigidbodyPedal = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("arr"))
        {
            Vector3 updatedPedal = new Vector3(GameObject.FindGameObjectWithTag("arr").transform.position.x * 32.0f, -5.852488f, 12.0f);
            transform.position = updatedPedal;
        }
        else
        {
            float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal"); // value is betweeen -1 to +1
            Vector2 playerVelocity = new Vector2(controlThrow * 13f, rigidbodyPedal.velocity.y);
            rigidbodyPedal.velocity = playerVelocity;
            // Debug.Log("xxxx:"+ transform.position.x + "yyy: "+ transform.position.y + "zzz:" + transform.position.z);

        }
        /*float farePozUnitCinsinden = Input.mousePosition.x / Screen.width * ekranGenisligiUnitCinsinden;
        farePozUnitCinsinden = Mathf.Clamp(farePozUnitCinsinden, xMin, xMax);
        Vector2 pedalPozisyonu = new Vector2(farePozUnitCinsinden, transform.position.y);
        transform.position = pedalPozisyonu;*/
    }

}
