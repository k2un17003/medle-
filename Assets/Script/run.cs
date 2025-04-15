using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    public Animator myAniamtor;
    public int speed = 5;

    
    // Start is called before the first frame update
    void Start()
    {
        float direction = Input.GetAxis("Horizontal");
        if (direction > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            myAniamtor.SetBool("move", true);
        }
        else if (direction < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            myAniamtor.SetBool("move", true);
        }
        else
            myAniamtor.SetBool("move", false);
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
