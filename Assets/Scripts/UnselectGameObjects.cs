using UnityEngine;
using UnityEngine.EventSystems;

public class UnselectGameObjects : MonoBehaviour
{
    /*
    This script unselects all the gameobjects.

    This is particularly useful in addressing the issue of gameobjects (especially
    GUI elements) staying highlighted even after the cursor is moved away after
    clicking them.

    The core issue lies in the technical fact that any gameobject is considered
    as the 'selected' object after clicking it (its like the windows 'focus'
    rectangle around the current field). Hence, the list of 'selected' objects
    must be nullified in order to address this issue.

    However, gameobjects such as Text Fields require to be selected in order to
    enable text input. This problem of selective selectivity can be tackled
    by reviewing the currently selected gameobject and nullifying the list of
    'selected' objects only if it is not amongst the selectable gameogjects.
    */

    // Selectable GameObjects
    public GameObject[] ListOfGameObjects;
    private bool isSelectedInList = false;

    void Start()
    {
        if (ListOfGameObjects.Length != 0)
        {
            foreach (GameObject obj in ListOfGameObjects)
            {
                if (EventSystem.current.currentSelectedGameObject == obj)
                {
                    isSelectedInList = true;
                    break;
                }
            }
        }
        if (!isSelectedInList)
        {
            EventSystem.current.SetSelectedGameObject(null);
        }
    }

    void Update()
    {
        if (ListOfGameObjects.Length != 0)
        {
            foreach (GameObject obj in ListOfGameObjects)
            {
                if (EventSystem.current.currentSelectedGameObject == obj)
                {
                    isSelectedInList = true;
                    break;
                }
            }
        }
        if (!isSelectedInList)
        {
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}
