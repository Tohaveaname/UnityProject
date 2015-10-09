using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BookMaster : MonoBehaviour {

    public static BookMaster instance = null;
    public int startPage = 1;
    public int currentPage = 1;
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
    public Text pageElevenPartThree;
    public Text pageTwelve;
    public Text pageThirteen;
    public GameObject nightTimeBackground;
    public GameObject apple;
    public GameObject pears;
    public GameObject plums;
    public GameObject strawberries;
    public GameObject oranges;
    public GameObject notFruitFood;
    public GameObject moon;
    public GameObject egg;
    public GameObject brokenEgg;
    public GameObject sunStatic;
    public GameObject sunAnimation;
    public GameObject caterpillar;
    public GameObject stomachAcheCaterpillar;
    public GameObject leaf;
    public GameObject cocoon;
    public GameObject butterfly;
    public GameObject openGesture;

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
            // Page 1
            case 1:
                pageOne.gameObject.SetActive(true);
                break;

            // Page 2 part 1
            case 2:
                pageOne.gameObject.SetActive(false);
                pageTwoPartOne.gameObject.SetActive(true);
                break;

            // Page 2 part 2
            case 3:
                pageTwoPartTwo.gameObject.SetActive(true);
                break;

            // Page 3
            case 4:
                pageTwoPartOne.gameObject.SetActive(false);
                pageTwoPartTwo.gameObject.SetActive(false);
                pageThree.gameObject.SetActive(true);
                break;

            // Page 4
            case 5:
                pageThree.gameObject.SetActive(false);
                pageFour.gameObject.SetActive(true);
                break;
            
            // Page 5
            case 6:
                pageFour.gameObject.SetActive(false);
                pageFive.gameObject.SetActive(true);
                break;

            // Page 6
            case 7:
                pageFive.gameObject.SetActive(false);
                pageSix.gameObject.SetActive(true);
                break;

            // Page 7
            case 8:
                pageSix.gameObject.SetActive(false);
                pageSeven.gameObject.SetActive(true);
                break;

            // Page 8
            case 9:
                pageSeven.gameObject.SetActive(false);
                pageEight.gameObject.SetActive(true);
                break;

            // Page 9 part 1
            case 10:
                pageEight.gameObject.SetActive(false);
                pageNinePartOne.gameObject.SetActive(true);
                break;

            // Page 9 part 2
            case 11:
                pageNinePartTwo.gameObject.SetActive(true);
                break;

            // Page 10
            case 12:
                pageNinePartOne.gameObject.SetActive(false);
                pageNinePartTwo.gameObject.SetActive(false);
                pageTen.gameObject.SetActive(true);
                break;
            
            // Page 11 part 1
            case 13:
                pageTen.gameObject.SetActive(false);
                pageElevenPartOne.gameObject.SetActive(true);
                break;

            // Page 11 part 2
            case 14:
                pageElevenPartTwo.gameObject.SetActive(true);
                break;
            
            // Page 11 part 3
            case 15:
                pageElevenPartTwo.gameObject.SetActive(false);
                pageElevenPartThree.gameObject.SetActive(true);
                break;

            // Page 12
            case 16:
                pageElevenPartOne.gameObject.SetActive(false);
                pageElevenPartThree.gameObject.SetActive(false);
                pageTwelve.gameObject.SetActive(true);
                break;

            // Page 13
            case 17:
                pageTwelve.gameObject.SetActive(false);
                pageThirteen.gameObject.SetActive(true);
                break;
            default:
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
                nightTimeBackground.SetActive(true);
                moon.SetActive(true);
                egg.SetActive(true);
                break;

            //Page 2 part 1
            case 2:
                nightTimeBackground.SetActive(true);
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
                leaf.SetActive(false);
                brokenEgg.SetActive(false);
                sunAnimation.SetActive(false);
                break;

            //Page 4
            case 5:
                apple.SetActive(true);
                break;

            //Page 5
            case 6:
                apple.SetActive(false);
                pears.SetActive(true);
                break;

            //Page 6
            case 7:
                pears.SetActive(false);
                plums.SetActive(true);
                break;

            //Page 7
            case 8:
                plums.SetActive(false);
                strawberries.SetActive(true);
                break;

            //Page 8
            case 9:
                strawberries.SetActive(false);
                oranges.SetActive(true);
                break;

            //Page 9 part 1
            case 10:
                oranges.SetActive(false);
                notFruitFood.SetActive(true);
                break;

            //Page 9 part 2
            case 11:
                caterpillar.SetActive(false);
                stomachAcheCaterpillar.SetActive(true);
                break;

            //Page 10
            case 12:
                notFruitFood.SetActive(false);
                leaf.SetActive(true);
                stomachAcheCaterpillar.SetActive(false);
                caterpillar.SetActive(true);
                break;

            //Page 11 part 1
            case 13:
                leaf.SetActive(false);
                break;

            //Page 11 part 2
            case 14:
                openGesture.SetActive(true);
                break;
            
            //Page 11 part 3
            case 15:
                openGesture.SetActive(false);
                break;

            //Page 12
            case 16:
                caterpillar.SetActive(false);
                //fatCaterpillar.SetActive(false);
                cocoon.SetActive(true);
                break;

            //Page 13
            case 17:
                cocoon.SetActive(false);
                butterfly.SetActive(true);
                break;

            default:
                break;
        }
    }
}

