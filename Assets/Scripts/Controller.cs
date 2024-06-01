using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
     [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.forward * speed * Time.deltaTime);

         if (Input.GetKey(KeyCode.A))
         {
             RotateRT();
         }

          if (Input.GetKey(KeyCode.D))
         {
             RotateLT();
         }
    }

   void RotateLT()
    {
        if (Mathf.Round(transform.eulerAngles.z) > 330 ||  Mathf.Round(transform.eulerAngles.z) < 30)
        {
            transform.Rotate(0, 0, -30 * Time.deltaTime);
            print(Mathf.Round(transform.eulerAngles.z));
        }
        else if (Mathf.Round(transform.eulerAngles.z) == 30)
        {
            transform.Rotate(0, 0, -1);
        }

    }

    void RotateRT()
    {
        if (Mathf.Round(transform.eulerAngles.z) < 30 || Mathf.Round(transform.eulerAngles.z) > 330)
        {
            transform.Rotate(0, 0, 30  * Time.deltaTime);
            print(Mathf.Round(transform.eulerAngles.z));
        }

        else if (Mathf.Round(transform.eulerAngles.z) == 330)
        {
            transform.Rotate(0, 0, 1);
        }
    }
}
