using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnClick : MonoBehaviour
{
   public GameObject[] objs;
   public string objectCoords = "";
   public string nameCard1, nameCard2;
   public string coords;
   public List<string> cObj;
   public int cardCounter = 0;

   void Start()
   {
   }

   void Update()
   {
    //increase counter every time mouse button is hit and call clicked cards function
       if(Input.GetMouseButtonDown(0)) {
           cardCounter++;
           ClickedCard(GetCoords());
       }
      
   }


    //when the mouse button is hit this is automatically called
   private void OnMouseDown() {
    //call the destroy card function and return a coordinate value
    objectCoords = DestroyCard();
   }

    //clicked card function take in a coordinate variable
   void ClickedCard(string coordinates){
    //load all objects into the array
      objs = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
      //use a for loop to loop throuhg the array
      for(int i = 0; i < objs.Length; i++) {
        //get the objects name
          string objsName = objs[i].name;
          //if it is one of these items just ignore it
          if(objsName == "Main Camera" || objsName == "CharacterGrid" || objsName == "GridManager") {
              objsName = "null-1000";
          }
          //create a string array for the object names and divide the coordinates of the object to the name
          string[] objsNameSplit = objsName.ToString().Split('-');


            //if the coorndiates of the object are the same as hte ones of the card destroyed that means it is the right card
          if(coordinates == objsNameSplit[1]){
            //assigne the name of the correct card to the name card 1 variable
               nameCard1 = objsNameSplit[0].ToString();
          }
      }
      //add the caribale to the list of cards that have been turned over by calling add list function
       AddToList(nameCard1, cObj);
   }

    //add list functoii takes a string ffor the object name and list argument
   void AddToList(string obj, List<string> list) {
        cObj.Add(obj); // add the name retirved from the clicked card function to the list of objects of cards that have been turned over

        //loop thorugh array to output the object and the list size to the console
       foreach(var c in cObj) {
            Debug.Log(c);
            Debug.Log(cObj.Count);
       }

        /*

            All of these if statems check to see after 2,4,6,8,10,12,14,16
            cards have been turned over if the one provious to it matcjes the name
            if it doesnt match is will reset the game and turn the cards back over
            if it is a match it will continue on until the game is over

        */
       if(cardCounter == 2) {
            if(cObj[0] == cObj[1]) {
                Debug.Log("Match");
            }
            else {
                Debug.Log("No Match");
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
            }
       }
       else if(cardCounter ==  4) {
            if(cObj[3] == cObj[2]) {
                Debug.Log("Match");
            }
            else {
                Debug.Log("No Match");
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
            }
       }
       else if(cardCounter ==  6) {
            if(cObj[5] == cObj[4]) {
                Debug.Log("Match");
            }
            else {
                Debug.Log("No Match");
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
            }
       }
       else if(cardCounter ==  8) {
            if(cObj[7] == cObj[6]) {
                Debug.Log("Match");
            }
            else {
                Debug.Log("No Match");
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
            }
       }
       else if(cardCounter ==  10) {
            if(cObj[9] == cObj[8]) {
                Debug.Log("Match");
            }
            else {
                Debug.Log("No Match");
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
            }
       }
       else if(cardCounter ==  12) {
            if(cObj[11] == cObj[10]) {
                Debug.Log("Match");
            }
            else {
                Debug.Log("No Match");
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
            }
       }
       else if(cardCounter ==  14) {
            if(cObj[13] == cObj[12]) {
                Debug.Log("Match");
            }
            else {
                Debug.Log("No Match");
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
            }
       }
       else if(cardCounter ==  16) {
            if(cObj[15] == cObj[14]) {
                Debug.Log("You Win!!!!");
                Application.Quit();
            }
            else {
                Debug.Log("No Match");
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
            }
       }
   }

    //Destroy card function 
   string DestroyCard() {
        //stores the card that was clicked ons name
        string currentCard = this.gameObject.name;
        //splits the name to get the coordinates
        string[] coordinates = currentCard.Split('-');
        //destroyes that card
        Destroy(GameObject.Find(currentCard));
        //returnes the corodinates
        return coordinates[1];
   }

    //Get the coordinates for the object
   string GetCoords() {
    //Register where the mous click occured
        float inputX = Input.mousePosition.x;
        float inputY = Input.mousePosition.y;
        /*
            with these if statments it records where the user clicked on the screen
            if it is between specific coordinates we know that tehy cliccked on a specific card so we
            can return the coordinates to the update function to retirve the name of the object at that spot
        */
        if(181f < inputX && 230f > inputX && inputY > 255f && 325f > inputY) {
            return "012";
        }
        else if(251f < inputX && 300f > inputX && inputY > 255f && 325f > inputY) {
            return "312";
        }
        else if(320f < inputX && 370f > inputX && inputY > 255f && 325f > inputY) {
            return "612";
        }
        else if(390f < inputX && 440f > inputX && inputY > 255f && 325f > inputY) {
            return "912";
        }
        else if(181f < inputX && 230f > inputX && inputY > 188f && 255f > inputY) {
            return "08";
        }
        else if(251f < inputX && 300f > inputX && inputY > 188f && 255f > inputY) {
            return "38";
        }
        else if(320f < inputX && 370f > inputX && inputY > 188f && 255f > inputY) {
            return "68";
        }
        else if(390f < inputX && 440f > inputX && inputY > 188f && 255f >inputY) {
            return "98";
        }
        else if(181f < inputX && 230f > inputX && inputY > 95f && 165f > inputY) {
            return "04";
        }
        else if(251f < inputX && 300f > inputX && inputY > 95f && 165f > inputY) {
            return "34";
        }
        else if(320f < inputX && 370f > inputX && inputY > 95f && 165f > inputY) {
            return "64";
        }
        else if(390f < inputX && 440f > inputX && inputY > 95f && 165f >inputY) {
            return "94";
        }
        else if(181f < inputX && 230f > inputX && inputY > 0f && 75f > inputY) {
            return "00";
        }
        else if(251f < inputX && 300f > inputX && inputY > 0f && 75f > inputY) {
            return "30";
        }
        else if(320f < inputX && 370f > inputX && inputY > 0f && 75f > inputY) {
            return "60";
        }
        else if(390f < inputX && 440f > inputX && inputY > 0f && 75f >inputY) {
            return "90";
        }
        else {
            return "00";
        }
   }
}
