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

         if (Input.GetKeyDown(KeyCode.A));
         {
             RotateLT();
         }

          if (Input.GetKeyDown(KeyCode.D));
         {
             RotateRT();
         }
    }

    void RotateLT()
    {
         transform.Rotate(0, 0, -30);
         print("wqd");
    }

    void RotateRT()
    {
        transform.Rotate(0, 0, 30);
        print("rty");
    }
}
