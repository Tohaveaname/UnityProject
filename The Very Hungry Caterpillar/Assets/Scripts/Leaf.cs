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
                gameObject.transform.localScale = new Vector3(0.9f, 0.8f, 0);
                gameObject.transform.position = new Vector3(-0.05f, -2.5f, 0);
                break;

            // Page 10
            case 12:
                gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 0);
                gameObject.transform.position = new Vector3(-0.1f, -1.2f, 0);
                break;

            default:
                break;
        }
    }
}
