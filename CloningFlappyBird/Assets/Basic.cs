using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        TestFunction();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestFunction(){
        print("Haha");
        print("¸ÖºÁ");
        print("gogogogo");
        transform.Translate(speed, 0, 0);
    }
}
