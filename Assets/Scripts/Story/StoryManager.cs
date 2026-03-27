using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public static StoryManager Instance;

    public int currentStep = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void NextStep()
    {
        currentStep++;
        Debug.Log("Step: " + currentStep);
    }

    public bool IsStep(int step)
    {
        return currentStep == step;
    }
}