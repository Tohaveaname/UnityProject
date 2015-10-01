using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BookMaster : MonoBehaviour {

    public static BookMaster instance = null;
    public int startPage = 1;
    public int currentPage = 1;

    //public GUIText[] pages;
    public Text pageOne;
    public Text pageTwoPartOne;
    public Text pageTwoPartTwo;
    public Text pageThree;
    public Text pageFour;
    public Text pageFive;
    public Text pageSix;
    public Text pageSeven;
    public Text pageEight;
    public Text pageNinePartOne;
    public Text pageNinePartTwo;
    public Text pageTen;
    public Text pageElevenPartOne;
    public Text pageElevenPartTwo;
    public Text pageTwelve;
    public Text pageThirteen;
    public GameObject moon;
    public GameObject egg;
    public GameObject brokenEgg;
    public GameObject sunStatic;
    public GameObject sunAnimation;
    public GameObject caterpillar;
    public GameObject stomachAcheCaterpillar;
    public GameObject butterfly;

    // Makes this class into a singleton as we don't want more than one book master
    void Awake()
    {
        // Checks if instance already exists
        if (instance == null)
        {
            instance = this;
        }
        // If an instance already exists and it's not this
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);   
    }

    // Use this for initialization
	void Start ()
    {
        currentPage = startPage;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Moves on if a page when space is pressed.
        if (Input.GetKeyDown("space"))
        {
            ++currentPage;
            HandleText();
            HandleScene();
        }
	}

    //Displays the correct text at the correct page
    void HandleText()
    {
        switch (currentPage)
        {
            case 1:
                pageOne.gameObject.SetActive(true);
                break;
            case 2:
                pageOne.gameObject.SetActive(false);
                pageTwoPartOne.gameObject.SetActive(true);
                break;
            case 3:
                pageTwoPartTwo.gameObject.SetActive(true);
                break;
            case 4:
                pageTwoPartOne.gameObject.SetActive(false);
                pageTwoPartTwo.gameObject.SetActive(false);
                pageThree.gameObject.SetActive(true);
                break;
            case 5:
                pageThree.gameObject.SetActive(false);
                pageFour.gameObject.SetActive(true);
                break;
            case 6:
                pageFour.gameObject.SetActive(false);
                pageFive.gameObject.SetActive(true);
                break;
            case 7:
                pageFive.gameObject.SetActive(false);
                pageSix.gameObject.SetActive(true);
                break;
            case 8:
                pageSix.gameObject.SetActive(false);
                pageSeven.gameObject.SetActive(true);
                break;
            case 9:
                pageSeven.gameObject.SetActive(false);
                pageEight.gameObject.SetActive(true);
                break;
            case 10:
                pageEight.gameObject.SetActive(false);
                pageNinePartOne.gameObject.SetActive(true);
                break;
            case 11:
                pageNinePartTwo.gameObject.SetActive(true);
                break;
            case 12:
                pageNinePartOne.gameObject.SetActive(false);
                pageNinePartTwo.gameObject.SetActive(false);
                pageTen.gameObject.SetActive(true);
                break;
            case 13:
                pageTen.gameObject.SetActive(false);
                pageElevenPartOne.gameObject.SetActive(true);
                break;
            case 14:
                pageElevenPartTwo.gameObject.SetActive(true);
                break;
            case 15:
                pageElevenPartOne.gameObject.SetActive(false);
                pageElevenPartTwo.gameObject.SetActive(false);
                pageTwelve.gameObject.SetActive(true);
                break;
            case 16:
                pageTwelve.gameObject.SetActive(false);
                pageThirteen.gameObject.SetActive(true);
                break;
        }
    }

    //Handles The main characters and props on each page
    void HandleScene()
    {
        switch (currentPage)
        {
            //Page 1
            case 1:
                moon.SetActive(true);
                egg.SetActive(true);
                break;
            //Page 2 part 1
            case 2:
                moon.SetActive(false);
                sunStatic.SetActive(true);
                break;
            //Page 2 part 2
            case 3:
                egg.SetActive(false);
                sunStatic.SetActive(false);
                brokenEgg.SetActive(true);
                caterpillar.SetActive(true);
                sunAnimation.SetActive(true);
                break;
            //Page 3
            case 4:
                brokenEgg.SetActive(false);
                sunAnimation.SetActive(false);
                break;
            //Page 4
            case 5:
                //apple.SetActive(true);
                break;
            //Page 5
            case 6:
                //apple.SetActive(false);
                //pearOne.SetActive(true);
                //pearTwo.SetActive(true);
                break;
            //Page 6
            case 7:
                //pearOne.SetActive(false);
                //pearTwo.SetActive(false);
                //plumOne.SetActive(true);
                //plumTwo.SetActive(true);
                //plumThree.SetActive(true);
                break;
            //Page 7
            case 8:
                //plumOne.SetActive(false);
                //plumTwo.SetActive(false);
                //plumThree.SetActive(false);
                //strawberryOne.SetActive(true);
                //strawberryTwo.SetActive(true);
                //strawberryThree.SetActive(true);
                //strawberryFour.SetActive(true);
                break;
            //Page 8
            case 9:
                //strawberryOne.SetActive(false);
                //strawberryTwo.SetActive(false);
                //strawberryThree.SetActive(false);
                //strawberryFour.SetActive(false);
                //orangeOne.SetActive(true);
                //orangeTwo.SetActive(true);
                //orangeThree.SetActive(true);
                //orangeFour.SetActive(true);
                //orangeFive.SetActive(true);
                break;
            //Page 9 part 1
            case 10:
                //orangeOne.SetActive(false);
                //orangeTwo.SetActive(false);
                //orangeThree.SetActive(false);
                //orangeFour.SetActive(false);
                //orangeFive.SetActive(false);
                //chocolateCake.SetActive(true);
                //iceCream.SetActive(true);
                //pickle.SetActive(true);
                //cheese.SetActive(true);
                //salami.SetActive(true);
                //lollipop.SetActive(true);
                //pie.SetActive(true);
                //sausage.SetActive(true);
                //cupcake.SetActive(true);
                //watermelon.SetActive(true);
                break;
            //Page 9 part 2
            case 11:
                caterpillar.SetActive(false);
                stomachAcheCaterpillar.SetActive(true);
                break;
            //Page 10
            case 12:
                //chocolateCake.SetActive(false);
                //iceCream.SetActive(false);
                //pickle.SetActive(false);
                //cheese.SetActive(false);
                //salami.SetActive(false);
                //lollipop.SetActive(false);
                //pie.SetActive(false);
                //sausage.SetActive(false);
                //cupcake.SetActive(false);
                //watermelon.SetActive(false);
                //leaf.SetActive(true);
                stomachAcheCaterpillar.SetActive(false);
                caterpillar.SetActive(true);

                break;
            //Page 11 part 1
            case 13:
                //leaf.SetActive(false);
                //staticCaterpillar.SetActive(true);
                break;
            //Page 11 part 2
            case 14:
                //staticCaterpillar.SetActive(false);
                //fatCaterpillar.SetActive(true);
                break;
            //Page 12
            case 15:
                caterpillar.SetActive(false);
                //fatCaterpillar.SetActive(false);
                //cocoon.SetActive(true);
                break;
            //Page 13
            case 16:
                //cocoon.SetActive(false);
                butterfly.SetActive(true);
                break;
        }
    }
}

