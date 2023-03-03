using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class random_create : MonoBehaviour
{
    [SerializeField] GameObject danger;
    private float leftBorder = -8.0f;
    private float rightBorder = 8.0f;
    private float topBorder = 5.0f;

    [SerializeField] float start_waiting;
    [SerializeField] float loop_waiting;

    private void Start()
    {
        StartCoroutine(random_creator());
    }
    IEnumerator random_creator()
    {
        yield return new WaitForSeconds(start_waiting);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(leftBorder, rightBorder),topBorder,12.0f);
                Instantiate(danger, vec, Quaternion.identity);
                yield return new WaitForSeconds(loop_waiting);
            }

            


        }
    }
}
