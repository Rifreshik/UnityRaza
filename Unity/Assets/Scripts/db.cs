using UnityEngine;
using Firebase.Database;

public class DB : MonoBehaviour

{
    DatabaseReference dbRef;
    void Start()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;

    }
    public void SaveData(string str)
    {
        dbRef.Child("users").Child("name").SetValueAsync(str);
    }   
}
