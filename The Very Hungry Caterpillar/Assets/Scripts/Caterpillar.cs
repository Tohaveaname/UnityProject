using UnityEngine;
using System.Collections;

public class Caterpillar : MonoBehaviour {

    public BookMaster bookmaster;
    Animator animator;

    //Uses this to retrieve the animator component of
    //the caterpillar.
    void Start () {
        animator = GetComponent<Animator>();
    }

    //Calles CaterpillarAction() every frame.
    void Update()
    {
        CaterpillarAction();
    }

    //Dictates what the caterpillar should do on each page.
    void CaterpillarAction()
    {
        switch (bookmaster.currentPage)
        {
            //Cover
            //Moves and scales the caterpillar.
            case 1:
                gameObject.transform.localScale = new Vector3(2.0f, 2.0f, 0);
                gameObject.transform.position = new Vector3(-2.0f, 0-1.0f, 0);
                break;

            //Page 2 part 3.
            //Moves and scales the caterpillar.
            case 6:
                gameObject.transform.localScale = new Vector3(0.28f, 0.28f, 0);
                gameObject.transform.position = new Vector3(-0.83f, -1.75f, 0);
                break;

            //Page 3.
            //Moves and scales the caterpillar.
            case 7:
                gameObject.transform.localScale = new Vector3(-1.0f, 1.0f, 0);
                gameObject.transform.position = new Vector3(0, 0, 0);
                break;

            //Page 4.
            //Moves and scales the caterpillar.
            case 8:
                gameObject.transform.localScale = new Vector3(-0.9f, 0.9f, 0);
                gameObject.transform.position = new Vector3(-3.6f, 0, 0);
                break;

            //Page 5.
            //Moves and scales the caterpillar.
            case 9:
                gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0);
                gameObject.transform.position = new Vector3(3.9f, -0.3f, 0);
                break;

            //Page 6.
            //Moves and scales the caterpillar.
            case 10:
                gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 0);
                gameObject.transform.position = new Vector3(-4.8f, -1.9f, 0);
                break;

            //Page 7.
            //Moves and scales the caterpillar.
            case 11:
                gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0);
                gameObject.transform.position = new Vector3(5.2f, 1.6f, 0);
                break;

            //Page 8.
            //Moves and scales the caterpillar.
            case 12:
                gameObject.transform.localScale = new Vector3(-0.35f, 0.35f, 0);
                gameObject.transform.position = new Vector3(-4.8f, -1.9f, 0);
                break;

            //Page 9 part 1.
            //Moves and scales the caterpillar.
            case 13:
                gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0);
                gameObject.transform.position = new Vector3(3.6f, -2f, 0);
                break;

            //Page 10.
            //Moves and scales the caterpillar.
            case 15:
                gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 0);
                gameObject.transform.position = new Vector3(0, 0, 0);
                break;

            //Page 11 part 3.
            //Moves and scales the caterpillar also triggers
            //"CaterpillarGrow" so the animation will play correctly.
            case 18:
                gameObject.transform.localScale = new Vector3(1.7f, 1.7f, 0);
                gameObject.transform.position = new Vector3(0, 0, 0);
                animator.SetTrigger("CaterpillarGrow");
                break;

            //The default is for the switch statement to do nothing.
            default:
                break;
        }
    }
}
