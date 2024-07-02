
using UnityEditor;

[CustomEditor(typeof(Interactable), true)]
public class InteracableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactable interactable = (Interactable)target;
        if(target.GetType() == typeof(EventOnlyInteractable))
        {
            interactable.promptMessage = EditorGUILayout.TextField("Prompt Message", interactable.promptMessage);
         EditorGUILayout.HelpBox("EventOnlyInteract can ONLY use UnityEvents",MessageType.Info);
        if(interactable.GetComponent<InteractableEvent>() == null)
        {
            interactable.useEvents = true;
            interactable.gameObject.AddComponent<InteractableEvent>();
        }
        }

        else
        {
        base.OnInspectorGUI();
        if (interactable.useEvents)
        {
            if (interactable.GetComponent<Interactable>() != null)
            interactable.gameObject.AddComponent<InteractableEvent>();
        }
        else
        {
            if (interactable.GetComponent<Interactable>() != null)
            DestroyImmediate(interactable.GetComponent<InteractableEvent>());
        }
    }
}
}