using UnityEngine;

public class Interactable : MonoBehaviour
{
    public int requiredStep;
    public int nextStep;

    public string message;

    public void Interact()
    {
        if (StoryManager.Instance.IsStep(requiredStep))
        {
            Debug.Log(message);

            // TODO: Replace with UI later
            Trigger();

            StoryManager.Instance.NextStep();
        }
        else
        {
            Debug.Log("Nothing happens...");
        }
    }

    void Trigger()
    {
        // You can customize per object later
    }
}