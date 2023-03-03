using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lives;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("arr"))
        {
            pos = new Vector3(GameObject.FindGameObjectWithTag("arr").transform.position.x, GameObject.FindGameObjectWithTag("arr").transform.position.y, GameObject.FindGameObjectWithTag("arr").transform.position.z);
            lives.text = pos.ToString();
        } else
        {
            lives.text = "error";

        }

    }
}
