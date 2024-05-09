using UnityEngine;
using UnityEngine.UI;

public class NoteManager : MonoBehaviour
{
    public GameObject[] notes;
    private int currentNoteIndex = 0;
    bool tabPressed = false; 

    void Start()
    {
        //ShowCurrentNote();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !tabPressed) 
        {
            tabPressed = true;

            ToggleNotesVisibility(); 
        }

        if (!Input.GetKey(KeyCode.Tab))
        {
            tabPressed = false; 
        }

        if (notes[currentNoteIndex].activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                ShowNextNote();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ShowPreviousNote();
            }
        }
    }

    void ToggleNotesVisibility()
    {
        notes[currentNoteIndex].SetActive(!notes[currentNoteIndex].activeSelf);
    }

    void ShowNextNote()
    {
        notes[currentNoteIndex].SetActive(false);
        currentNoteIndex = (currentNoteIndex + 1) % notes.Length;
        ShowCurrentNote();
    }

    void ShowPreviousNote()
    {
        notes[currentNoteIndex].SetActive(false);
        currentNoteIndex = (currentNoteIndex - 1 + notes.Length) % notes.Length;
        ShowCurrentNote();
    }

    void ShowCurrentNote()
    {
        notes[currentNoteIndex].SetActive(true);
    }
}






/*
using UnityEngine;
using UnityEngine.UI; // Для работы с UI объектами

public class NoteManager : MonoBehaviour
{
    public GameObject noteUI;
    public GameObject[] notes; // Массив для хранения картинок записок
    private int currentNoteIndex = 0;
    
    void Start()
    {
        noteUI.SetActive(false);
        ShowCurrentNote();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleNoteUI();
        }

        if (noteUI.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                ShowNextNote();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ShowPreviousNote();
            }
        }
    }

    void ToggleNoteUI()
    {
        noteUI.SetActive(!noteUI.activeSelf);
    }
    
    void ShowNextNote()
    {
        currentNoteIndex = (currentNoteIndex + 1) % notes.Length;
        ShowCurrentNote();
    }

    void ShowPreviousNote()
    {
        currentNoteIndex = (currentNoteIndex - 1 + notes.Length) % notes.Length;
        ShowCurrentNote();
    }

    void ShowCurrentNote()
    {
        for (int i = 0; i < notes.Length; i++)
        {
            notes[i].SetActive(i == currentNoteIndex);
        }
    }
}
*/