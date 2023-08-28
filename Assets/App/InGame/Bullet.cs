using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private int life = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate (0.0f ,0.1f, 0.0f);
        life--;
        if(life < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
