using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BookMaster : MonoBehaviour {

    //Establishing instance for singleton pattern.
    public static BookMaster instance = null;

    //Initiates start page and current page to one.
    public int startPage = 1;
    public int currentPage = 1;

    //Text for each of the pages.
    public Text pageOne;
    public Text pageTwoPartOne;
    public Text pageTwoPartTwo;
    public Text pageTwoPartThree;
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

    //Characters and Scenery.
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

    //Gestures.
    public GameObject openGesture;
    public GameObject waveGesture;

    //Makes this class into a singleton as we don't want more 
    //than one book master.
    void Awake()
    {
        //Checks if instance already exists.
        if (instance == null)
        {
            instance = this;
        }
        //If an instance already exists and it's not this.
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);   
    }

    //Sets the current page to the start page.
	void Start ()
    {
        currentPage = startPage;
	}
	
	//Checks if the space key has been pressed this frame.
    //If it has it increments the current page and calls
    //HandleText() and HandleFrame().
	void Update ()
    {
        //Moves on a page when space is pressed that frame.
        if (Input.GetKeyDown("space"))
        {
            ++currentPage;
            HandleText();
            HandleScene();
        }
	}

    //Displays the correct text at the correct page.
    void HandleText()
    {
        switch (currentPage)
        {
            //Page 1.
            //Sets inactive: none.
            //Sets active: pageOne.
            case 1:
                pageOne.gameObject.SetActive(true);
                break;

            //Page 2 part 1.
            //Sets inactive: pageOne.
            //Sets active: pageTwoPartOne.
            case 2:
                pageOne.gameObject.SetActive(false);
                pageTwoPartOne.gameObject.SetActive(true);
                break;

            //Page 2 part 2.
            //Sets inactive: none.
            //Sets active: pageTwoPartTwo.
            case 3:
                pageTwoPartTwo.gameObject.SetActive(true);
                break;

            //Page 2 part 3.
            //Sets inactive: pageTwoPartTwo.
            //Sets active: pageTwoPartThree.
            case 4:
                pageTwoPartTwo.gameObject.SetActive(false);
                pageTwoPartThree.gameObject.SetActive(true);
                break;

            //Page 3.
            //Sets inactive: pageTwoPartOne and pageTwoPartThree.
            //Sets active: pageThree.
            case 5:
                pageTwoPartOne.gameObject.SetActive(false);
                pageTwoPartThree.gameObject.SetActive(false);
                pageThree.gameObject.SetActive(true);
                break;

            //Page 4.
            //Sets inactive: pageThree.
            //Sets active: pageFour.
            case 6:
                pageThree.gameObject.SetActive(false);
                pageFour.gameObject.SetActive(true);
                break;

            //Page 5.
            //Sets inactive: pageFour.
            //Sets active: pageFive.
            case 7:
                pageFour.gameObject.SetActive(false);
                pageFive.gameObject.SetActive(true);
                break;

            //Page 6.
            //Sets inactive: pageFive.
            //Sets active: pageSix.
            case 8:
                pageFive.gameObject.SetActive(false);
                pageSix.gameObject.SetActive(true);
                break;

            //Page 7.
            //Sets inactive: pageSix.
            //Sets active: pageSeven.
            case 9:
                pageSix.gameObject.SetActive(false);
                pageSeven.gameObject.SetActive(true);
                break;

            //Page 8.
            //Sets inactive: pageSeven.
            //Sets active: pageEight.
            case 10:
                pageSeven.gameObject.SetActive(false);
                pageEight.gameObject.SetActive(true);
                break;

            //Page 9 part 1.
            //Sets inactive: pageEight.
            //Sets active: pageNinePartOne.
            case 11:
                pageEight.gameObject.SetActive(false);
                pageNinePartOne.gameObject.SetActive(true);
                break;

            //Page 9 part 2.
            //Sets inactive: none.
            //Sets active: pageNinePartTwo.
            case 12:
                pageNinePartTwo.gameObject.SetActive(true);
                break;

            //Page 10.
            //Sets inactive: pageNinePartOne and pageNinePartTwo.
            //Sets active: pageTen.
            case 13:
                pageNinePartOne.gameObject.SetActive(false);
                pageNinePartTwo.gameObject.SetActive(false);
                pageTen.gameObject.SetActive(true);
                break;

            //Page 11 part 1.
            //Sets inactive: pageTen.
            //Sets active: pageElevenPartOne.
            case 14:
                pageTen.gameObject.SetActive(false);
                pageElevenPartOne.gameObject.SetActive(true);
                break;

            //Page 11 part 2.
            //Sets inactive: none.
            //Sets active: pageElevenPartTwo.
            case 15:
                pageElevenPartTwo.gameObject.SetActive(true);
                break;

            // Page 11 part 3.
            //Sets inactive: pageElevenPartTwo.
            //Sets active: pageElevenPartThree.
            case 16:
                pageElevenPartTwo.gameObject.SetActive(false);
                pageElevenPartThree.gameObject.SetActive(true);
                break;

            //Page 12.
            //Sets inactive: pageElevenPartOne and ElevenPartThree.
            //Sets active: pageTwelve.
            case 17:
                pageElevenPartOne.gameObject.SetActive(false);
                pageElevenPartThree.gameObject.SetActive(false);
                pageTwelve.gameObject.SetActive(true);
                break;

            //Page 13.
            //Sets inactive: pageTwelve.
            //Sets active: pageThirteen
            case 18:
                pageTwelve.gameObject.SetActive(false);
                pageThirteen.gameObject.SetActive(true);
                break;

            //The default is for the switch statement to do nothing.
            default:
                break;
        }
    }

    //Handles The main characters and props on each page.
    void HandleScene()
    {
        switch (currentPage)
        {
            //Page 1.
            //Sets inactive: none.
            //Sets active: nightTimeBackground, moon, leaf and egg.
            case 1:
                nightTimeBackground.SetActive(true);
                moon.SetActive(true);
                leaf.SetActive(true);
                egg.SetActive(true);
                break;

            //Page 2 part 1.
            //Sets inactive: nightTimeBackground and moon.
            //Sets active: sunStatic.
            case 2:
                nightTimeBackground.SetActive(false);
                moon.SetActive(false);
                sunStatic.SetActive(true);
                break;

            //Page 2 part 2.
            //Sets inactive: none.
            //Sets active: waveGesture.
            case 3:
                waveGesture.SetActive(true);
                break;

            // Page 2 part 3.
            //Sets inactive: waveGesture, egg and sunStatic.
            //Sets active: brokenEgg, caterpillar and sunAnimation.
            case 4:
                waveGesture.SetActive(false);
                egg.SetActive(false);
                sunStatic.SetActive(false);
                brokenEgg.SetActive(true);
                caterpillar.SetActive(true);
                sunAnimation.SetActive(true);
                break;

            //Page 3.
            //Sets inactive: leaf, brokenEgg and sunAnimation.
            //Sets active: none.
            case 5:
                leaf.SetActive(false);
                brokenEgg.SetActive(false);
                sunAnimation.SetActive(false);
                break;

            //Page 4.
            //Sets inactive: none.
            //Sets active: apple.
            case 6:
                apple.SetActive(true);
                break;

            //Page 5.
            //Sets inactive: apple.
            //Sets active: pears.
            case 7:
                apple.SetActive(false);
                pears.SetActive(true);
                break;

            //Page 6.
            //Sets inactive: pears.
            //Sets active: plums.
            case 8:
                pears.SetActive(false);
                plums.SetActive(true);
                break;

            //Page 7.
            //Sets inactive: plums.
            //Sets active: strawberries.
            case 9:
                plums.SetActive(false);
                strawberries.SetActive(true);
                break;

            //Page 8.
            //Sets inactive: strawberries.
            //Sets active: oranges.
            case 10:
                strawberries.SetActive(false);
                oranges.SetActive(true);
                break;

            //Page 9 part 1.
            //Sets inactive: oranges.
            //Sets active: notFruitFood.
            case 11:
                oranges.SetActive(false);
                notFruitFood.SetActive(true);
                break;

            //Page 9 part 2.
            //Sets inactive: caterpillar.
            //Sets active: stomachAcheCaterpillar.
            case 12:
                caterpillar.SetActive(false);
                stomachAcheCaterpillar.SetActive(true);
                break;

            //Page 10.
            //Sets inactive: notFruitFood and stomachAcheCaterpillar.
            //Sets active: leaf and caterpillar.
            case 13:
                notFruitFood.SetActive(false);
                stomachAcheCaterpillar.SetActive(false);
                leaf.SetActive(true);
                caterpillar.SetActive(true);
                break;

            //Page 11 part 1.
            //Sets inactive: leaf.
            //Sets active: none.
            case 14:
                leaf.SetActive(false);
                break;

            //Page 11 part 2.
            //Sets inactive: none.
            //Sets active: openGesture.
            case 15:
                openGesture.SetActive(true);
                break;

            //Page 11 part 3.
            //Sets inactive: openGesture.
            //Sets active: none.
            case 16:
                openGesture.SetActive(false);
                break;

            //Page 12.
            //Sets inactive: caterpillar.
            //Sets active: cocoon.
            case 17:
                caterpillar.SetActive(false);
                cocoon.SetActive(true);
                break;

            //Page 13.
            //Sets inactive: cocoon.
            //Sets active: butterfly.
            case 18:
                cocoon.SetActive(false);
                butterfly.SetActive(true);
                break;

            //The default is for the switch statement to do nothing.
            default:
                break;
        }
    }
}

