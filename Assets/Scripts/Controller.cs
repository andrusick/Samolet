using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
     [SerializeField] private float speed;
     [SerializeField] private float speedTurn;
     [SerializeField] private float rotationSpeed;
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
             transform.Translate(new Vector3(1  , 0, 0) * speedTurn * Time.deltaTime);
             StopCoroutine(ResetCourutine());
         }

          else if (Input.GetKey(KeyCode.D))
         {
             RotateLT();
             transform.Translate(new Vector3(-1, 0, 0) * speedTurn * Time.deltaTime);
             StopCoroutine(ResetCourutine());
         }
         else
         {
             StartCoroutine(ResetCourutine());
         }
    }

   void RotateLT()
    {
        if (Mathf.Round(transform.eulerAngles.z) > 330 ||  Mathf.Round(transform.eulerAngles.z) < 30)
        {
            transform.Rotate(0, 0, -30 * Time.deltaTime);
            
            
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
            
        }

        else if (Mathf.Round(transform.eulerAngles.z) == 330)
        {
            transform.Rotate(0, 0, 1);
        }
    }
    
    IEnumerator ResetCourutine()
    {
        Quaternion targetRotation = Quaternion.identity;

        while(transform.rotation != targetRotation)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            yield return null;
        }
    }
}
