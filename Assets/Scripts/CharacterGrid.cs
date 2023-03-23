using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrid : MonoBehaviour
{
    public GameObject popeyePrefab, minionPrefab, scoobyPrefab, beanPrefab, mousePrefab, noddyPrefab, shinchanPrefab, doraemonPrefab, blankPrefab;

    void Start() {
        for (var y = 0; y < 16; y+=4) {// y value fo grid because it jumps by 4
            for (var x = 0; x < 12; x+=3) { // x value of grid because it jumps by 3
                var pos = new Vector3 (x, y);// assigns an x,y value to the object for the grid
                switch(Random.Range(1,8))
                {
                     /*
                        each case instantiates a random sprite on the board by using a random number
                        generator and assignes a x,y value as well as a name
                    */
                case 1:
                    Instantiate(popeyePrefab, pos, Quaternion.identity).name = $"popeye-{x}{y}";
                break;
                case 2:
                    Instantiate(minionPrefab, pos, Quaternion.identity).name = $"minion-{x}{y}";
                break;                 
                case 3:
                    Instantiate(scoobyPrefab, pos, Quaternion.identity).name = $"scooby-{x}{y}";
                break;
                case 4:
                    Instantiate(beanPrefab, pos, Quaternion.identity).name = $"bean-{x}{y}";
                break;    
                case 5:
                    Instantiate(mousePrefab, pos, Quaternion.identity).name = $"mouse-{x}{y}";
                break;
                case 6:
                    Instantiate(noddyPrefab, pos, Quaternion.identity).name = $"noddy-{x}{y}";
                break;
                case 7:
                    Instantiate(shinchanPrefab, pos, Quaternion.identity).name = $"shinchan-{x}{y}";
                break;
                case 8:
                    Instantiate(doraemonPrefab, pos, Quaternion.identity).name = $"doraemon{x}{y}";
                break;
                }
            }
        }
        StartCoroutine(waiting());
    }

    IEnumerator waiting() {
        yield return new WaitForSecondsRealtime(4);
        LoadBlanks();
    }

    void LoadBlanks() {

        for (var y = 0; y < 16; y+=4) {// y value fo grid because it jumps by 4
            for (var x = 0; x < 12; x+=3) { // x value of grid because it jumps by 3
                var pos = new Vector3 (x, y);// assigns an x,y value to the object for the grid
                switch(Random.Range(1,8))
                    {
                        /*
                            each case instantiates a random sprite on the board by using a random number
                            generator and assignes a x,y value as well as a name
                        */
                    case 1:
                        Instantiate(blankPrefab, pos, Quaternion.identity).name = $"blank1-{x}{y}";
                    break;
                    case 2:
                        Instantiate(blankPrefab, pos, Quaternion.identity).name = $"blank2-{x}{y}";
                    break;                 
                    case 3:
                        Instantiate(blankPrefab, pos, Quaternion.identity).name = $"blank3-{x}{y}";
                    break;
                    case 4:
                        Instantiate(blankPrefab, pos, Quaternion.identity).name = $"blank4-{x}{y}";
                    break;    
                    case 5:
                        Instantiate(blankPrefab, pos, Quaternion.identity).name = $"blank5-{x}{y}";
                    break;
                    case 6:

                        Instantiate(blankPrefab, pos, Quaternion.identity).name = $"blank6-{x}{y}";
                    break;
                    case 7:
                        Instantiate(blankPrefab, pos, Quaternion.identity).name = $"blank7-{x}{y}";
                    break;
                    case 8:
                        Instantiate(blankPrefab, pos, Quaternion.identity).name = $"blank8{x}{y}";
                    break;
                }
            }
        }
    }
}
