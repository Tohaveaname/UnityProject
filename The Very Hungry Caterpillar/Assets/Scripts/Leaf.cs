using UnityEngine;
using System.Collections;

public class Leaf : MonoBehaviour
{

    public BookMaster bookmaster;

    //Calls LeafAction() every frame.
    void Update()
    {
        LeafAction();
    }

    //Activates and moves leaf where appropriate.
    void LeafAction()
    {
        switch (bookmaster.currentPage)
        {
            //Page 1.
            //Moves and scales leaf as needed.
            case 3:
                gameObject.transform.localScale = new Vector3(1.8f, 1.5f, 0);
                gameObject.transform.position = new Vector3(0.9f, -1.9f, 0);
                break;

            //Page 10.
            //Moves and scales leaf as needed.
            case 15:
                gameObject.transform.localScale = new Vector3(2.2f, 1.7f, 0);
                gameObject.transform.position = new Vector3(-0.19f, -0.77f, 0);
                break;

            //The default is for the switch statement to do nothing.
            default:
                break;
        }
    }
}
