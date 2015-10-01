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
}

