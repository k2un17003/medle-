using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SimpleMoveScript : MonoBehaviour
{
    public int Speed = 5;
   
    // Start is called before the first frame update
    void Start()
    {
        float direction = Input.GetAxis("Horizontal");

        if (direction > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (direction < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        transform.Translate(Vector3.right * direction * Speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
