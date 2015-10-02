using UnityEngine;
using System.Collections;

public class Caterpillar : MonoBehaviour {

    public BookMaster bookmaster;
    Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CaterpillarAction();
    }

    //Dictates what the caterpillar should do on each page.
    void CaterpillarAction()
    {
        switch (bookmaster.currentPage)
        {
            // Page 2 part 2
            case 3:
                gameObject.transform.localScale = new Vector3(0.28f, 0.28f, 0);
                gameObject.transform.position = new Vector3(-0.83f, -1.75f, 0);
                break;
            // Page 3
            case 4:
                gameObject.transform.localScale = new Vector3(-1.0f, 1.0f, 0);
                gameObject.transform.position = new Vector3(0, 0, 0);
                break;
            // Page 4
            case 5:
                gameObject.transform.localScale = new Vector3(-0.9f, 0.9f, 0);
                gameObject.transform.position = new Vector3(-3.6f, 0, 0);
                break;
            // Page 5
            case 6:
                gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0);
                gameObject.transform.position = new Vector3(3.9f, -0.3f, 0);
                break;
            // Page 6
            case 7:
                gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 0);
                gameObject.transform.position = new Vector3(-4.8f, -1.9f, 0);
                break;
            // Page 7
            case 8:
                gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0);
                gameObject.transform.position = new Vector3(5.2f, 1.6f, 0);
                break;
            // Page 8
            case 9:
                gameObject.transform.localScale = new Vector3(-0.35f, 0.35f, 0);
                gameObject.transform.position = new Vector3(-4.8f, -1.9f, 0);
                break;
            // Page 9 part 1
            case 10:
                gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0);
                gameObject.transform.position = new Vector3(3.6f, -2f, 0);
                break;
            // Page 10
            case 12:
                gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 0);
                gameObject.transform.position = new Vector3(0, 0, 0);
                break;
            // Page 11 part 2
            case 14:
                gameObject.transform.localScale = new Vector3(1.7f, 1.7f, 0);
                gameObject.transform.position = new Vector3(0, 0, 0);
                animator.SetTrigger("CaterpillarGrow");
                break;
            default:
                break;
        }
    }
}
