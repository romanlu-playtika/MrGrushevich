using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private readonly List<GameEventsListener> listeners = new List<GameEventsListener>();

    public void Raise()
    {
        for (int i = listeners.Count; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(GameEventsListener listener)
    {
        listeners.Add(listener);
    }
    public void RemoveListener(GameEventsListener listener)
    {
        listeners.Remove(listener);
    }
}
