using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookControllerDef : MonoBehaviour
{
    [SerializeField] private BookSO _bookInfo;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
