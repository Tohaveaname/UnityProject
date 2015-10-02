using UnityEngine;
using System.Collections;

public class Leaf : MonoBehaviour
{

    public BookMaster bookmaster;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        LeafAction();

    }

    void LeafAction()
    {
        switch (bookmaster.currentPage)
        {
            // Page 1
            case 1:
                gameObject.transform.localScale = new Vector3(1.8f, 1.5f, 0);
                gameObject.transform.position = new Vector3(0.9f, -1.9f, 0);
                break;

            // Page 10
            case 12:
                gameObject.transform.localScale = new Vector3(2.2f, 1.7f, 0);
                gameObject.transform.position = new Vector3(-0.19f, -0.77f, 0);
                break;

            default:
                break;
        }
    }
}
