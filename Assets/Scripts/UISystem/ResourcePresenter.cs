using UnityEngine;
using UnityEngine.UI;

public class ResourcePresenter : MonoBehaviour
{
    [SerializeField] Resource resource;
    [SerializeField] Text resourceText;

    private void Start()
    {
        if(resource) resource.ResourceChanged += OnResourceChanged;

        UpdateView();
    }

    public void Build(int amount)
    {
        resource?.Decrement(amount);
    }

    public void Increment(int amount)
    {
        resource?.Increment(amount);
    }

    public void Reset()
    {
        resource?.Reset();
    }

    public void UpdateView()
    {
        if(!resource) return;

        if(resourceText && resource.maxResource != 0)
        {
            resourceText.text = resource.currentResource.ToString();
        }
    }

    public void OnResourceChanged()
    {
        UpdateView();
    }
}